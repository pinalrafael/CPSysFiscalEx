using CPSysFiscal.NFe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSysFiscalEx
{
    class Program
    {
        static void Main(string[] args)
        {
            NFe nFe = new NFe();
            CPSysFiscal.NFe.Campos.infNFe infNFe = new CPSysFiscal.NFe.Campos.infNFe();
            CPSysFiscal.NFe.Campos.emit emit = new CPSysFiscal.NFe.Campos.emit();
            CPSysFiscal.NFe.Campos.ide ide = new CPSysFiscal.NFe.Campos.ide();

            emit.CNPJ = "11111111111111";

            ide.cUF = "14";
            ide.nNF = "000000001";

            nFe.emit = emit;
            nFe.ide = ide;
            nFe.infNFe = infNFe;

            string retorno = nFe.getXMLNFe();

            Console.WriteLine(retorno);
            Console.ReadKey();
        }
    }
}
