namespace PetStore.Common
{
    public class Constants
    {
        public const string ConnectionString = @"Server=.\SQLEXPRESS;Database=PetStore;Integrated Security=True;";

        //Owner
        public const int OwnerMaxLengthName = 30;
        public const int OwnerMinLengthName = 4;

        //Pet
        public const int PetMaxLengthName = 30;
        public const int PetMinLengthName = 4;
        public const int PetMaxAge = 200;
        public const int PetMinAge = 1;
    }
}
