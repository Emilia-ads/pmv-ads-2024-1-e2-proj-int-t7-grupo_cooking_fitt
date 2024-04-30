namespace CkkingFitComView.Models
{
    public class ConsumoCalorico
    {
        public Genero genero { get; set; }
        public AlturaH alturah { get; set; }

        public AlturaM alturam { get; set; }
        public Atividade atividade { get; set; }

    }
    public enum Genero
    {
        Masculino = 1,
        Feminino = 2
    }

    public enum Atividade
    {
        poucoativo = 1,
        ativo = 2,
        muitoativo = 3
    }

    public enum AlturaM
    {
        a150m = 1,
        a155m = 2,
        a160m = 3,
        a165m = 4,
        a170m = 5,
        a175m = 6,
        a180m = 7,


    }
    public enum AlturaH
    {
        a160m = 1,
        a165m = 2,
        a170m = 3,
        a175m = 4,
        a180m = 5,
        a185m = 6,
        a190m = 7

    }

    public Resultadocaloria(Genero genero) 
    {
        if (genero = ) {

        }
    }
}
