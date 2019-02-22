using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DynamicFormFields.Models
{
    
    public class ItemForm
    {
        public IEnumerable<SelectListItem> ItemNames { get; set; }

        public int? SelectedItemId { get; set; }

        public DynamicFieldWrapper ExtraFields { get; set; }
    }

}
