using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SqlDataAccess.Settings
{
    public class OrderBySettings<T>
    {
        public Expression<Func<T, object>> PropertySelector { get; private set; }
        public bool IsAscending { get; private set; }

        public OrderBySettings(Expression<Func<T, object>> propertySelector, bool isAscending = true)
        {
            if (propertySelector == null)
            {
                throw new ArgumentNullException(nameof(propertySelector));
            }
            PropertySelector = propertySelector;
            IsAscending = isAscending;
        }
    }
}
