using LecturesProjectExample.Example.Entities;

namespace LecturesProjectExample.Example.Extensions
{
    public static class GenderUtils
    {
        private static IEnumerable<Gender> _genders = new List<Gender>()
        {
            Gender.Undefined,
            Gender.Female,
            Gender.Male,
        };

        public static IEnumerable<Gender> GetAll()
        {
            return _genders;
        }
    }
}
