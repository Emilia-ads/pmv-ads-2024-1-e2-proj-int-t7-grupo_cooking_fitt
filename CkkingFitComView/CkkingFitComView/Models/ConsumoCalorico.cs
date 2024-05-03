using CkkingFitComView.Models;


namespace CkkingFitComView.Models
{
    public class ConsumoCalorico
    {
        public Genero genero { get; set; }
        public AlturaH alturah { get; set; }
        public AlturaM alturam { get; set; }
        public Atividade atividade { get; set; }
        public Idade idade { get; set; }

        public double GetAltura()
        {
            if (genero == Genero.Masculino)
            {
                return (double)alturah / 100; // Convertendo para metros
            }
            else
            {
                return (double)alturam / 100; // Convertendo para metros
            }
        }

        public double FatorAtividade()
        {
            switch (atividade)
            {
                case Atividade.poucoativo:
                    return 1.2;
                case Atividade.ativo:
                    return 1.375;
                case Atividade.muitoativo:
                    return 1.55;
                default:
                    throw new ArgumentException("Atividade inválida.");
            }
        }

        public double CalcularCaloriasDiarias()
        {
            double taxaMetabolicaBasal;

            if (genero == Genero.Masculino)
            {
                taxaMetabolicaBasal = 88.362 + (13.397 * GetAltura()) - (5.677 * (int)idade);
            }
            else
            {
                taxaMetabolicaBasal = 447.593 + (9.247 * GetAltura()) - (4.330 * (int)idade);
            }

            double caloriasDiarias = taxaMetabolicaBasal * FatorAtividade();
            return caloriasDiarias;
        }
    }

    public enum Genero
    {
        Masculino = 1,
        Feminino = 2
    }

    public enum Atividade
    {
        poucoativo = 1, //1.2
        ativo = 2, //1.375
        muitoativo = 3 //1.55
    }

    public enum AlturaM
    {
        a150m = 150,
        a155m = 155,
        a160m = 160,
        a165m = 165,
        a170m = 170,
        a175m = 175,
        a180m = 180
    }

    public enum AlturaH
    {
        a160m = 160,
        a165m = 165,
        a170m = 170,
        a175m = 175,
        a180m = 180,
        a185m = 185,
        a190m = 190
    }

    public enum Idade
    {
        i18a = 18,
        i19a = 19,
        i20a = 20,
        i21a = 21,
        i22a = 22,
        i23a = 23,
        i24a = 24,
        i25a = 25,
        i26a = 26,
        i27a = 27,
        i28a = 28,
        i29a = 29,
        i30a = 30,
        i31a = 31,
        i32a = 32,
        i33a = 33,
        i34a = 34,
        i35a = 35,
        i36a = 36,
        i37a = 37,
        i38a = 38,
        i39a = 39,
        i40a = 40,
        i41a = 41,
        i42a = 42,
        i43a = 43,
        i44a = 44,
        i45a = 45,
        i46a = 46,
        i47a = 47,
        i48a = 48,
        i49a = 49,
        i50a = 50
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConsumoCalorico consumo = new ConsumoCalorico()
            {
                genero = Genero.Masculino,
                alturah = AlturaH.a170m, // Exemplo: Altura de 170 cm
                atividade = Atividade.ativo, // Exemplo: Atividade ativa
                idade = Idade.i30a // Exemplo: Idade de 30 anos
            };

            double caloriasDiarias = consumo.CalcularCaloriasDiarias();
            Console.WriteLine($"Calorias diárias necessárias: {caloriasDiarias} kcal");
        }
    }
}