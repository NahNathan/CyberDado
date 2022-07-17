internal class Dado{
    private static void Main(string[] args){

        //Declarando as variáveis
        int faces=0, mod=0, rolada=0, selec=0;

        //Começo
        Random r = new Random();
        Console.WriteLine("Bom dia, CyberDado Iniciado");
        try{
            do{
               Console.WriteLine("Digite o numero de faces do dado a ser rolado");
                faces=System.Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o numero do modificador");
                mod=System.Convert.ToInt32(Console.ReadLine());
                //Por enquanto só isso, vou fazer pra rolar mais de uma vez dps
                //Mostrando os resultados
                Console.Clear();
                rolada=r.Next(1, faces);
                Console.WriteLine("Rolada: " + rolada);
                Console.WriteLine("Modificador: " + mod);
                Console.WriteLine("Total: " + (rolada+mod));
                Console.WriteLine("Outra Rolada?");
                Console.WriteLine("(Digite 1 para encerrar)");
                selec=System.Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            
            }while(selec!=1);
        }

        catch(System.FormatException){
            Console.WriteLine("Inválido, fechando dado");
        }
        //Jeito bem BEM ruim de se fazer isso, eu sei
        //Corrijo outro dia, essa é só a prova de conceito msm

        Console.WriteLine("Obrigado por usar esse programa");
        Console.ReadLine();
    }
}