using System;
namespace AtvSen
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
                Console.WriteLine("Informar nome");
                string var_name = Console.ReadLine();
                Console.WriteLine("Informar endereço");
                string var_endereco = Console.ReadLine();
                Console.WriteLine("Pessoa Física (f) ou Júridica (j)?");
                string var_tipo = Console.ReadLine();
                if(var_tipo == "f")
                {
                    // Pessoa Física
                    Pessoa_Fisica pf = new Pessoa_Fisica();
                    pf.name = var_name;
                    pf.endereco = var_endereco;
                    Console.WriteLine("Informar CPF: ");
                    pf.cpf = Console.ReadLine();
                    Console.WriteLine("Informar RG: ");
                    pf.rg = Console.ReadLine();
                    Console.WriteLine("Informar Valor de Compra: ");
                    val_pag = float.Parse(Console.ReadLine());
                    pf.Pagar_Imposto(val_pag);
                    Console.WriteLine("--------Pessoa Física--------");
                    Console.WriteLine("Nome...........:" + pf.name);
                    Console.WriteLine("Endereço.......:" + pf.endereco);
                    Console.WriteLine("CPF............:" + pf.cpf);
                    Console.WriteLine("RG.............:" + pf.rg);
                    Console.WriteLine("Valor de compra:" + pf.valor.ToString("C"));
                    Console.WriteLine("Imposto........:" + pf.valor_imposto.ToString("C"));
                    Console.WriteLine("Total a Pagar..: " + pf.total.ToString("C"));
                }
                if(var_tipo == "j")
                {
                    //Júridica
                    Pessoa_Juridica pj = new Pessoa_Juridica();
                    pj.name = var_name;
                    pj.endereco = var_endereco;
                    Console.WriteLine("Informe seu CNPJ: ");
                    pj.cnpj = Console.ReadLine();
                    Console.WriteLine("Iformar IE");
                    pj.ie = Console.ReadLine();
                    Console.WriteLine("Informal o valor de Compra:");
                    val_pag = float.Parse(Console.ReadLine());
                    pj.Pagar_Imposto(val_pag);
                    Console.WriteLine("--------Pessoa Júridica--------");
                    Console.WriteLine("Nome...........:" + pj.name);
                    Console.WriteLine("Endereço.......:" + pj.endereco);
                    Console.WriteLine("CNPJ...........:" + pj.cnpj);
                    Console.WriteLine("IE.............:" + pj.ie);
                    Console.WriteLine("Valor de compra:" + pj.valor.ToString("C"));
                    Console.WriteLine("Imposto........:" + pj.valor_imposto.ToString("C"));
                    Console.WriteLine("Total a pagar..:" + pj.total.ToString("C"));
                }
        }
    }
}
