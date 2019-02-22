using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicFormFields.Models;

namespace DynamicFormFields.Repository
{
    public class DynamicFieldRepository
    {
        public static readonly DynamicField ServicePointNumber = new DynamicField { DisplayName = "Service Point Number", Id = "ServicePointNumber" };
        public static readonly DynamicField GuruAccountId = new DynamicField { DisplayName = "Guru Account Id", Id = "GuruAccountId" };

        public DynamicField[] GetFieldsByItem(int itemId)
        {
            switch (itemId)
            {
                case 1:
                    return new [] { ServicePointNumber };
                case 2:
                    return new [] { GuruAccountId };
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
