namespace DynamicFormFields.Models
{
    public class DynamicField {
        public bool IsRequired { get; set; }
        
        public string Id { get; set; }

        public string DisplayName { get; set; }
        
        public string Value { get; set; }
    }
}
