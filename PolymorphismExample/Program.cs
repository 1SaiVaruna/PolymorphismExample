namespace PolymorphismExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunIDS();

            Console.ReadLine();
        }

        static void RunIDS()
        {
            Attack[] attacks = new Attack[]
            {
                new DoSAttack(),
                new MalwareAttack()
            };

            foreach (Attack attack in attacks)
            {
                attack.DetectAttack();
            }
        }
    }
}
