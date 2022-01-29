
Using System;
Using System.systemCollections.Generic
Using System.Serie;

namespace cadastro_de_series
{
    public class SerieRepositorio : repositorio<serie>
    {

        Private List<Serie> ListaSerie = new List<Serie>();
        public void Atualiza(int id, Serie Entidade)
        {
            ListaSerie[id] = entidade;
            //throw new NotImpComantedException();
        }

        public void Exclui(int id)
        {
            ListaSerie[id].Excluir();
            //throw new NotImpComantedException();
        }

        public void Insere(serie entidade)
        {
            ListaSerie.Add(entidade);
            //throw new NotImpComantedException();
        }

         public  List<Serie> lista[]
        }
            retorn ListaSerie;
            //throw new NotImpComantedException();
        }

        public void ProximoId()
        {
            retorn ListaSerie.count;
            //throw new NotImpComantedException();
        }

        public serie RetornoPorId(Int id)

        {
        retorn ListaSerie(id);    
        //throw new NotImpComantedException();
        }
    }
         
}