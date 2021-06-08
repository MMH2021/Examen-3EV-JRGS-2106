namespace Examen3EV_NS
{
    using System.Collections.Generic;
    using System;
    //MCMHDAW2021
    /// <summary>
    /// Esta clase nos calcula las estadisticas de un conjunto de notas
    /// </summary>
    public class estaditicasNotas 
    {
        public const string listadenotasvacias = "listadenotasvacia";
        public const string notasfueradevariables = "notas fuera de variables";


        /// <summary>
        /// Define suspenso. Entero
        /// </summary>
        private int suspenso;

        /// <summary>
        /// Defines aprobado. Entero
        /// </summary>
        private int aprobado;

        /// <summary>
        /// Defines notable. Entero
        /// </summary>
        private int notable;

        /// <summary>
        /// Define sobresaliente. Entero
        /// </summary>
        private int sobresaliente;

        /// <summary>
        /// Define la media de tipo double
        /// </summary>
        private double media;

        /// <summary>
        /// Getter y Setter del suspenso
        /// </summary>
        public int Suspeso { get => suspenso; set { suspenso = value; } }

        /// <summary>
        ///  Getter y Setter del aprobado
        /// </summary>
        public int Aprobado { get => aprobado; set => aprobado = value; }

        /// <summary>
        ///  Getter y Setter del notable
        /// </summary>
        public int Notable { get => notable; set => notable = value; }

        /// <summary>
        ///  Getter y Setter del sobresaliente
        /// </summary>
        public int Sobresaliente { get => sobresaliente; set => sobresaliente = value; }

        /// <summary>
        ///  Getter y Setter de la media
        /// </summary>
        public double Media { get => media; set => media = value; }


        /// <summary>
        /// Inicializa la clase <see cref="estaditicasNotas"/> vacia.
        /// </summary>
        public estaditicasNotas()
        {
            Suspeso = Aprobado = Notable = Sobresaliente = 0;  
            Media = 0.0;
        }


        
        public estaditicasNotas(List<int> listnotas)
        {
            Media = 0.0;

            for (int i = 0; i < listnotas.Count; i++)
            {
                if (listnotas[i] < 5) suspenso++;              
                else if (listnotas[i] > 5 && listnotas[i] < 7) aprobado++;
                else if (listnotas[i] > 7 && listnotas[i] < 9) notable++;
                else if (listnotas[i] > 9) sobresaliente++;        

                Media = Media + listnotas[i];
            }

            Media = Media / listnotas.Count;

            
        }

        /// <summary>
        /// Para un conjunto de listanotas, calculamos las estadísticas
        /// calcula la media y el número de suspensos/aprobados/notables/sobresalientes
        /// </summary>
        /// <param name="listaNotas">The listaNotas<see cref="List{int}"/>.</param>
        /// <returns>devuelve error si hay error, la media de contrario</returns>
        public double CalcularEstadisticasNotas(List<int> listaNotas)
        {
            Media = 0.0;

            
            if (listaNotas.Count <= 0)  
                throw new ArgumentOutOfRangeException(listadenotasvacias);

            for (int i = 0; i < 10; i++)
                if (listaNotas[i] < 0 || listaNotas[i] > 10)    
                    throw new ArgumentOutOfRangeException(notasfueradevariables);

            for (int i = 0; i < listaNotas.Count; i++)
            {
                if (listaNotas[i] < 5) suspenso++;              
                else if (listaNotas[i] >= 5 && listaNotas[i] < 7) aprobado++;
                else if (listaNotas[i] >= 7 && listaNotas[i] < 9) notable++;
                else if (listaNotas[i] > 9) suspenso++;        

                Media = Media + listaNotas[i];
            }

            Media = Media / listaNotas.Count;

            return Media;
        }
            
        }
    }

