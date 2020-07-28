﻿namespace PetStore.Common
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

        //PetStoreService
        public const string NotExistMessage = "{0} not exist, sorry";

        //Food
        public const string NoEnoughQuantityFood = "No enough quantity food";

        //Client
        public const int MinLengthUsername = 5;
        public const int MaxLengthUsername = 40;

        public const int MinLengthPassword = 10;
        public const int MaxLengthPassword = 100;
    }
}