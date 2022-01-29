using systemCollections.Generic;

    
namespace cadastro_de_series.Interfaces
{
    public interface repositorio<T>
    
    {
        List<T> lista(); 
        RetornoPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id , T entidade);
        int Proximoid();
    }
}