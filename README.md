# CPSysFiscal
-----

[NuGet Packages](https://www.nuget.org/packages/CPSysFiscal/)
<br/>
.NET Framework 4.7.2

# A DLL
-----

A biblioteca foi criada com a finalidade de faciliar a geração de xml das NFe, NFSe e SAT CFe seguindo a documentação.

# USANDO
-----

1. Instale a biblioteca pelo pacote NuGet Packages;
2. Todos os campos estão seguindo a respectiva documentação com informações obtidas nelas.
3. Você irá encontrar informações do TAM => Tamanho e DEC => Decimais dos campos.
4. Campos com 0-1 são campos opcionais e campos 1-500 são listas com no máximo 500 itens.
5. Inicie as classes;
```cs
NFe nFe = new NFe();
CFe cFe = new CFe();
CFeCanc cFeCanc = new CFeCanc();
```
6. Informe os campos que irá usar
```cs
CPSysFiscal.NFe.Campos.infNFe infNFe = new CPSysFiscal.NFe.Campos.infNFe();
            CPSysFiscal.NFe.Campos.emit emit = new CPSysFiscal.NFe.Campos.emit();
            CPSysFiscal.NFe.Campos.ide ide = new CPSysFiscal.NFe.Campos.ide();

            emit.CNPJ = "11111111111111";

            ide.cUF = "14";
            ide.nNF = "000000001";

            nFe.emit = emit;
            nFe.ide = ide;
            nFe.infNFe = infNFe;
```
7. Para receber o xml no cádigo use:
```cs
string retorno = nFe.getXMLNFe();
```
8. Para salvar o xml:
```cs
string retorno = nFe.SalvarXMLNFe("caminho", "nome sem ext");
```

# SUPORTE
-----

[**Siga-me**](https://github.com/pinalrafael?tab=followers) para minhas próximas criações