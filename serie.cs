namespace cadastro_de_series
{
    public class serie : Entidade
    {
        // Atributos

        public serie(Game genero, string titulo, string descricao, string ano) 
        {
            this.Genero = genero;
                this.Titulo = titulo;
                this.Descricao = descricao;
                this.Ano = ano;
                Private bool Exclui(get; set;)
               
               // Metodos 
               public serie(int id, Genero genero, string titulo, string descricao, int ano)

               this.Id = id;
               this.Genero = genero;
                this.Titulo = titulo;
                this.Descricao = descricao;
                this.Ano = ano;
                this.Exclui = false;
                {
                    public override string Tostring()

                    // Enviroment.newLine https://docs.microsoft.com/en-us/dotnet/api/system.Enviroment.new/Wiening:Core-3.3.;
                    String retorno = '';
                    retorn += "Genero: " + this.genero + Enviroment.newLine;
                    retorn += "Titulo: " + this.titulo + Enviroment.newLine;
                    retorn += "Descricao: " + this.descricao + Enviroment.newLine;
                    retorn += "Ano de Inicio: " this.Ano + Enviroment.newLine;
                    retorn retorno;
                    {
                        public string retorno.Titulo()
                    }
                        retorn this.titulo;
                    {
                        public string retorno.Id()
                    }
                        retorn this.Id;
                    }  

                        public void Exclui() {
                            this Exclui = true;  
            }
        }
    }     