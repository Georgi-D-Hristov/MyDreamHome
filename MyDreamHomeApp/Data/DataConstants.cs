namespace MyDreamHomeApp.Data
{
    public static class DataConstants
    {
        public static class Home
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 20;

            public const int TypeMinLength = 2;
            public const int TypeMaxLength = 20;
        }

        public static class Equipment
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 20;

            public const int TypeMinLength = 2;
            public const int TypeMaxLength = 20;

            public const double MinPrice = 0d;
            public const double MaxPrice = 1000000d;

            public const int BrandMinLength = 2;
            public const int BrandMaxLength = 20;
        }

        public static class Furniture
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 20;

            public const int TypeMinLength = 2;
            public const int TypeMaxLength = 20;

            public const double MinPrice = 0d;
            public const double MaxPrice = 1000000d;
        }

        public static class Room
        {
            public const double MaxArea = 1000d;
            public const double MinArea = 0.1d;
        }

        public static class Idea
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 20;
        }

        public static class Matirial
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 20;

            public const int TypeMinLength = 2;
            public const int TypeMaxLength = 20;

            public const double MinPrice = 0d;
            public const double MaxPrice = 1000000d;
        }
    }
}
