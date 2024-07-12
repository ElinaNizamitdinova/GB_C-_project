using GB_tasks;

namespace ConsoleApp1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            FamilyMember GrandmaOne = new FamilyMember()
            {
                Name = "Masha Malinina",
                Age = 70,
                Gender = Gender.woman
            };
            FamilyMember GrandpaOne = new FamilyMember()
            {
                Name = "Misha Malinin",
                Age = 76,
                Gender = Gender.man
            };
            FamilyMember GrandmaTwo = new FamilyMember()
            {
                Name = "Arina Kirova",
                Age = 70,
                Gender = Gender.woman
            };
            FamilyMember GrandpaTwo = new FamilyMember()
            {
                Name = "Oleg Kirov",
                Age = 78,
                Gender = Gender.man
            };
            FamilyMember MyMother = new FamilyMember()
            {
                Name = "Mila Kirova",
                Age = 46,
                Gender = Gender.woman,
                Father = GrandpaOne,
                Mother = GrandmaOne,
            };

            FamilyMember MyFather = new FamilyMember()
            {
                Name = "Nikita Kirov",
                Age = 50,
                Gender = Gender.man,
                Father = GrandpaTwo,
                Mother = GrandmaTwo

            };
            FamilyMember Husband = new FamilyMember()
            {
                Name = "Alex Illen",
                Age = 24,
                Gender = Gender.man

            };
            FamilyMember Me = new FamilyMember()
            {
                Name = "Vasilisa Kirova",
                Age = 20,
                Gender = Gender.man,
                Father = MyFather,
                Mother = MyMother,
                Spouse = Husband

            };
            var grandMothers = Me.GetGrandmothers();
            var grandfathers = Me.GetGrandfathers();
            Console.WriteLine(grandMothers[0].Name);
            Console.WriteLine(grandMothers[1].Name);
            Console.WriteLine();
            Console.WriteLine(grandfathers[0].Name);
            Console.WriteLine(grandfathers[1].Name);
            Console.WriteLine();
            Console.WriteLine(Me.Spouse.Name);

        }
    }
}
