namespace Interface
{
    public interface ICarrinho
    {
        //usado para ter um contrato de negócio e não esquecer de metódos necessários
        void Listar();

        void Cadastrar(Produto produto);
        void Alterar (int _codigo, Produto produto);
        void Deletar(Produto produto); 
    }
}