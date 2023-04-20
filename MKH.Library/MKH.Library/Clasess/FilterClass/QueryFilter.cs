using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace MKH.Library.Clasess.FilterClass
{
    public static class QueryFilter
    {

        //public static IQueryable<T> FilterForColumn<T>(this IQueryable<T> queryable, string colName, string searchText, ColumnType ColType)
        //{
        //    if (colName != null && searchText != null)
        //    {
        //        var parameter = Expression.Parameter(typeof(T), "m");
        //        var propertyExpression = Expression.Property(parameter, colName);
        //        System.Linq.Expressions.ConstantExpression searchExpression = null;
        //        System.Reflection.MethodInfo containsMethod = null;
        //        System.Linq.Expressions.Expression body = null;

        //        Expression ex1 = null;
        //        Expression ex2 = null;
                
        //        switch (ColType)
        //        {
        //            case ColumnType.Int32:
        //                Int32? _int1 = Convert.ToInt32(searchText);
        //                searchExpression = Expression.Constant(_int1);
        //                containsMethod = typeof(Int32?).GetMethod("Equals", new[] { typeof(Int32?) });
        //                //Error throws from this line
        //                //body = Expression.Call(propertyExpression, containsMethod, searchExpression);
                        
        //                var converted = Expression.Convert(searchExpression, typeof(object));
        //                body = Expression.Call(propertyExpression, containsMethod, converted);
        //                break;
        //            case ColumnType.Int64:
        //                Int64? _int2 = Convert.ToInt64(searchText);
        //                searchExpression = Expression.Constant(_int2);
        //                containsMethod = typeof(Int64?).GetMethod("Equals", new[] { typeof(Int64?) });
        //                var converted1 = Expression.Convert(searchExpression, typeof(object));
        //                body = Expression.Call(propertyExpression, containsMethod, converted1);
        //                break;
        //            //case "PublishDate":
        //            //case "Birth_date":
        //            //case "Anniversary_date":
        //            //case "Profile_Updated_datetime":
        //            //case "CompletedOn":
        //            //    DateTime currentDate = DateTime.ParseExact(searchText.ToString(), "dd/MM/yyyy", null);
        //            //    DateTime nextDate = currentDate.AddDays(1);
        //            //    ex1 = Expression.GreaterThanOrEqual(propertyExpression, Expression.Constant(currentDate, typeof(DateTime?)));
        //            //    ex2 = Expression.LessThan(propertyExpression, Expression.Constant(nextDate, typeof(DateTime?)));
        //            //    body = Expression.AndAlso(ex1, ex2);
        //            //    break;
        //            //// section for DateTime properties
        //            //case "Created_datetime":
        //            //case "Reminder_Date":
        //            //case "News_date":
        //            //case "thought_date":
        //            //case "SubscriptionDateTime":
        //            //case "Register_datetime":
        //            //case "CreatedOn":
        //            //    DateTime currentDate1 = DateTime.ParseExact(searchText.ToString(), "dd/MM/yyyy", null);
        //            //    DateTime nextDate1 = currentDate1.AddDays(1);
        //            //    ex1 = Expression.GreaterThanOrEqual(propertyExpression, Expression.Constant(currentDate1));
        //            //    ex2 = Expression.LessThan(propertyExpression, Expression.Constant(nextDate1));
        //            //    body = Expression.AndAlso(ex1, ex2);
        //            //    break;
        //            default:
        //                searchExpression = Expression.Constant(searchText);
        //                containsMethod = typeof(string).GetMethod("Contains", new[] { typeof(string) });
        //                body = Expression.Call(propertyExpression, containsMethod, searchExpression);
        //                break;
        //        }
        //        var predicate = Expression.Lambda<Func<T, bool>>(body, new[] { parameter });
        //        return queryable.Where(predicate);
        //    }
        //    else
        //    {
        //        return queryable;
        //    }
        //}
       
        //public static object ChangeType(object value, Type conversion)
        //{
        //    var t = conversion;

        //    if (t.IsGenericType && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
        //    {
        //        if (value == null)
        //        {
        //            return null;
        //        }

        //        t = Nullable.GetUnderlyingType(t);
        //    }

        //    return Convert.ChangeType(value, t);
        //}





        //public class SearchField
        //{
        //    public string Name { get; set; }
        //    public string @Value { get; set; }
            
        //    //public string Operator { get; set; }

        //    public SearchField(string Name, string @Value)//, string Operator)
        //    {
        //        this.Name = Name;
        //        this.@Value = @Value;
        //        //this.Operator = Operator;
        //    }
        //}

        //public class FilterLinq<T>
        //{
        //    public static Expression<Func<T, Boolean>> GetWherePredicate(params SearchField[] SearchFieldList)
        //    {

        //        //the 'IN' parameter for expression ie T=> condition
        //        ParameterExpression pe = Expression.Parameter(typeof(T), typeof(T).Name);

        //        //combine them with and 1=1 Like no expression
        //        Expression combined = null;

        //        if (SearchFieldList != null)
        //        {
        //            foreach (var fieldItem in SearchFieldList)
        //            {
        //                //Expression for accessing Fields name property
        //                Expression columnNameProperty = Expression.Property(pe, fieldItem.Name);


        //                //the name constant to match 
        //                Expression columnValue = Expression.Constant(fieldItem.Value);

        //                //the first expression: PatientantLastName = ?
        //                Expression e1 = Expression.Equal(columnNameProperty, columnValue);

        //                if (combined == null)
        //                {
        //                    combined = e1;
        //                }
        //                else
        //                {
        //                    combined = Expression.And(combined, e1);
        //                }
        //            }
        //        }

        //        //create and return the predicate
        //        return Expression.Lambda<Func<T, Boolean>>(combined, new ParameterExpression[] { pe });
        //    }

        //}




















        public enum ColumnType
        {
            Int16 = 1,
            Int32 = 2,
            Int64 = 3,
            DateString = 4,
            DateTime = 5,
            Boolean = 6,
            String = 7
        }


        public static class ExpressionBuilder
        {
            private static MethodInfo containsMethod = typeof(string).GetMethod("Contains");
            private static MethodInfo startsWithMethod =
                typeof(string).GetMethod("StartsWith", new Type[] { typeof(string) });
            private static MethodInfo endsWithMethod =
                typeof(string).GetMethod("EndsWith", new Type[] { typeof(string) });
            
            //GreaterThan,GreaterThanOrEqual,LessThan,LessThanOrEqual
            private static MethodInfo GreaterThanOrEqualMethod2 =
                typeof(string).GetMethod("GreaterThanOrEqual", new Type[] { typeof(string) });

            public static Expression<Func<T, bool>> GetExpression<T>(IList<Filter> filters)
            {
                if (filters.Count == 0)
                    return null;

                ParameterExpression param = Expression.Parameter(typeof(T), "t");
                Expression exp = GetExpression<T>(param, filters[0]);


                for (int i = 1; i < filters.Count; i++)
                {
                    if (filters[i-1].OperationFilter == OpFilter.And)
                        exp = Expression.AndAlso(exp, GetExpression<T>(param, filters[i]));
                    else
                        exp = Expression.OrElse(exp, GetExpression<T>(param, filters[i]));

                }
                
                //if (filters.Count == 1)
                //    exp = GetExpression<T>(param, filters[0]);
                //else if (filters.Count == 2)
                //    exp = GetExpression<T>(param, filters[0], filters[1]);
                //else
                //{
                //    while (filters.Count > 0)
                //    {
                //        var f1 = filters[0];
                //        var f2 = filters[1];

                //        if (exp == null)
                //            exp = GetExpression<T>(param, filters[0], filters[1]);
                //        else
                //        {
                //            if (f1.OperationFilter == OpFilter.And)
                //                exp = Expression.AndAlso(exp, GetExpression<T>(param, filters[0], filters[1]));
                //            else
                //                exp = Expression.OrElse(exp, GetExpression<T>(param, filters[0], filters[1]));
                //        }


                //        filters.Remove(f1);
                //        filters.Remove(f2);

                //        if (filters.Count == 1)
                //        {
                //            if (filters[0].OperationFilter == OpFilter.And)
                //                exp = Expression.AndAlso(exp, GetExpression<T>(param, filters[0]));
                //            else
                //                exp = Expression.OrElse(exp, GetExpression<T>(param, filters[0]));
                //            filters.RemoveAt(0);
                //        }
                //    }
                //}

                return Expression.Lambda<Func<T, bool>>(exp, param);
            }

            private static Expression GetExpression<T>(ParameterExpression param, Filter filter)
            {
                MemberExpression member = Expression.Property(param, filter.PropertyName);
                ConstantExpression constant = Expression.Constant(filter.Value, member.Type);
              
                switch (filter.Operation)
                {
                    case Op.Equals:
                        return Expression.Equal(member, constant);

                    case Op.GreaterThan:
                        return Expression.GreaterThan(member, constant);

                    case Op.GreaterThanOrEqual:
                        try { return Expression.GreaterThanOrEqual(member, constant); }
                        catch { return Expression.Call(member, GreaterThanOrEqualMethod2, constant); }

                    case Op.LessThan:
                        return Expression.LessThan(member, constant);

                    case Op.LessThanOrEqual:
                        return Expression.LessThanOrEqual(member, constant);

                    case Op.Contains:
                        return Expression.Call(member, containsMethod, constant);

                    case Op.StartsWith:
                        return Expression.Call(member, startsWithMethod, constant);

                    case Op.EndsWith:
                        return Expression.Call(member, endsWithMethod, constant);
                }
              

                return null;
            }

            private static BinaryExpression GetExpression<T>
            (ParameterExpression param, Filter filter1, Filter filter2)
            {
                Expression bin1 = GetExpression<T>(param, filter1);
                Expression bin2 = GetExpression<T>(param, filter2);

                if (filter1.OperationFilter == OpFilter.And)
                    return Expression.AndAlso(bin1, bin2);
                else return Expression.OrElse(bin1, bin2);
            }

            public class Filter
            {
                //public string PropertyName { get; set; }
                public string PropertyName { get; set; }
                public Op Operation { get; set; }
                public object Value { get; set; }
                public OpFilter OperationFilter { get; set; }
            }

            public enum Op
            {
                Equals,
                GreaterThan,
                LessThan,
                GreaterThanOrEqual,
                LessThanOrEqual,
                Contains,
                StartsWith,
                EndsWith
            }
            public enum OpFilter
            {
                And,
                Or
            }
        }

    }
}
