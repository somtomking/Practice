using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;


namespace Practice.Mvc5.Models
{
    public class FormModel
    {
        [Validator(typeof(OrderValidator))]//此行是重点
        public class Order
        {
            public Order()
            {
                Items = new List<OrderItem>();
            }
            public int Id { get; set; }

            public IList<int> AllowItems { get; set; }

            public string Name { get; set; }
            public int Count { get; set; }

            public List<OrderItem> Items { get; set; }
        }
        [Validator(typeof(OrderItemValidator))]
        public class OrderItem
        {
            public int Id { get; set; }
            //[Required(ErrorMessage = "订单项不能为空！")]
            public string Name { get; set; }
            //[Required(ErrorMessage = "金额不能为空！")]
            // [Range(10, 15, ErrorMessage = "金额必须在10和15之间")]
            public decimal Price { get; set; }
        }



        public class OrderValidator : AbstractValidator<Order>
        {
            public OrderValidator()
            {
                this.RuleFor(s => s.Name).NotEmpty().WithMessage("订单名称不能为空!");
                this.RuleFor(s => s.Count).GreaterThan(10).WithMessage("数量必须大于10");

                this.RuleForEach(s => s.Items).SetValidator(new OrderItemValidator());
            }
        }


        public class OrderItemValidator : AbstractValidator<OrderItem>
        {
            public OrderItemValidator()
            {
                this.RuleFor(s => s.Name).NotEmpty().WithMessage("订单项名不能为空!");
                this.RuleFor(s => s.Price).GreaterThan(15).WithMessage("金额必须大于15!");

            }
        }
    }


    public class CollectionModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            Type type = bindingContext.ModelType;
            object model = Activator.CreateInstance(bindingContext.ModelType);
            List<object> modelList = new List<object>();
            if (type.IsGenericType)
            {
                Type elementType = type.GetGenericArguments()[0];
                Type collectionType = typeof(ICollection<>).MakeGenericType(elementType);
                if (collectionType.IsInstanceOfType(model))
                {
                    NameValueCollection formData = HttpContext.Current.Request.Form;
                    List<string> keys = new List<string>();
                    foreach (var item in formData.Keys)
                    {
                        keys.Add(item.ToString());
                    }
                    foreach (PropertyInfo p in elementType.GetProperties())
                    {
                        List<string> usekeys = keys.Where(x => x.Contains(p.Name)).ToList();
                        while (modelList.Count < usekeys.Count)
                        {
                            object obj = Activator.CreateInstance(elementType);
                            modelList.Add(obj);
                        }
                        for (int i = 0; i < usekeys.Count; i++)
                        {
                            p.SetValue(modelList[i], formData[usekeys[i]], null);
                        }

                    }
                }

                ReplaceCollection(elementType, model, modelList);
                return model;
            }
            return null;
        }

        private static readonly MethodInfo _replaceCollectionMethod = typeof(CollectionModelBinder).GetMethod("ReplaceCollectionImpl", BindingFlags.Static | BindingFlags.NonPublic);


        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        public static void ReplaceCollection(Type collectionType, object collection, object newContents)
        {
            MethodInfo targetMethod = _replaceCollectionMethod.MakeGenericMethod(collectionType);
            targetMethod.Invoke(null, new object[] { collection, newContents });
        }

        private static void ReplaceCollectionImpl<T>(ICollection<T> collection, IEnumerable newContents)
        {
            collection.Clear();
            if (newContents != null)
            {
                foreach (object item in newContents)
                {
                    // if the item was not a T, some conversion failed. the error message will be propagated,
                    // but in the meanwhile we need to make a placeholder element in the array.
                    T castItem = (item is T) ? (T)item : default(T);
                    collection.Add(castItem);
                }
            }
        }
    }

}