internal class Dado{
    private static void Main(string[] args){

        //Declarando as variáveis
        int resp=0, faces=0, mod=0, rolada=0, num=0;

        //Começo
        Random r=new Random();
        
        Console.WriteLine("\n**==========================================**");
        Console.WriteLine("Bom dia, CyberDado Iniciado");
        Console.WriteLine("Cuidado para digitar apenas números válidos \n");
        try{
            do{
                //Recebendo dados (hehe)
                Console.WriteLine("Digite o número de dados a ser rolado");
                num=System.Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o número de faces do dado a ser rolado");
                faces=System.Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o número do modificador");
                mod=System.Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                
                //Mostrando os resultados
                for (int i=1; i<=num; i++){
                    rolada=r.Next(1, faces+1); //Rolando

                    Console.Write("\nRolada numero " + i + " :         " + rolada);
                    //Checando para ver se é um "crítico"
                    if(rolada==faces)
                        Console.Write("<--- Crítico!!\n");
                    else
                        Console.Write("\n"); //Isso é para mostrar na msm linha

                    Console.WriteLine("Modificador numero " + i + " :    " + mod);
                    Console.WriteLine("Total numero " + i + " :          "+ (rolada+mod));    
                }
                
                Console.WriteLine("\nOutra Rolada?");
                Console.WriteLine("(Digite 1 para encerrar)");
                resp=System.Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            
            }while(resp!=1);
        }

        catch(System.FormatException){
            Console.WriteLine("Inválido, fechando programa");
        }

        Console.WriteLine("Obrigado por usar esse programa");
        Console.ReadLine();
    }
}