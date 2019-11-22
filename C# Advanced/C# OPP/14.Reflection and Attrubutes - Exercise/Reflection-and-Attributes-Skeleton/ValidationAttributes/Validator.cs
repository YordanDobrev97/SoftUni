namespace ValidationAttributes
{
    public static class Validator 
    {
        public static bool IsValid(object obj)
        {
            bool isValid = true;

            var properties = obj.GetType().GetProperties();

            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes(false);

                foreach (MyValidationAttribute attribute in attributes)
                {
                    var currentAttribute = property.GetValue(obj);

                    if (!attribute.IsValid(currentAttribute))
                    {
                        isValid = false;
                    }
                }
            }

            return isValid;
        }
    }
}
