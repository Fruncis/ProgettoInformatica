﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProgettoInformatica.Properties {
    using System;
    
    
    /// <summary>
    ///   Classe di risorse fortemente tipizzata per la ricerca di stringhe localizzate e così via.
    /// </summary>
    // Questa classe è stata generata automaticamente dalla classe StronglyTypedResourceBuilder.
    // tramite uno strumento quale ResGen o Visual Studio.
    // Per aggiungere o rimuovere un membro, modificare il file con estensione ResX ed eseguire nuovamente ResGen
    // con l'opzione /str oppure ricompilare il progetto VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Restituisce l'istanza di ResourceManager nella cache utilizzata da questa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ProgettoInformatica.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Esegue l'override della proprietà CurrentUICulture del thread corrente per tutte le
        ///   ricerche di risorse eseguite utilizzando questa classe di risorse fortemente tipizzata.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Cerca una risorsa localizzata di tipo System.Byte[].
        /// </summary>
        public static byte[] coin {
            get {
                object obj = ResourceManager.GetObject("coin", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Cerca una stringa localizzata simile a &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;Carte&gt;
        ///	&lt;TipoMazzo&gt;Cinema&lt;/TipoMazzo&gt;
        ///	&lt;Immagine&gt;&lt;/Immagine&gt;
        ///	&lt;Livello&gt;3&lt;/Livello&gt;
        ///	&lt;Carta&gt;
        ///		&lt;Titolo&gt;Film classici&lt;/Titolo&gt;
        ///		&lt;Quesito&gt;Qual è il film diretto da Francis Ford Coppola nel 1972 che racconta la storia della famiglia Corleone?&lt;/Quesito&gt;
        ///		&lt;Risposte&gt;Il padrino&lt;/Risposte&gt;
        ///		&lt;Risposte&gt;Apocalypse Now&lt;/Risposte&gt;
        ///		&lt;Risposte&gt;Taxi Driver&lt;/Risposte&gt;
        ///		&lt;Risposte&gt;Casablanca&lt;/Risposte&gt;
        ///		&lt;RispostaCorretta&gt;Il padrino&lt;/RispostaCorretta&gt;
        ///	&lt;/Carta&gt;
        ///	&lt;Cart [stringa troncata]&quot;;.
        /// </summary>
        public static string mazzo_cinema {
            get {
                return ResourceManager.GetString("mazzo_cinema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Cerca una stringa localizzata simile a &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot; ?&gt;
        ///&lt;Carte&gt;
        ///	&lt;TipoMazzo&gt;Geografia&lt;/TipoMazzo&gt;
        ///	&lt;Immagine&gt;&lt;/Immagine&gt;
        ///	&lt;Livello&gt;1&lt;/Livello&gt;
        ///	&lt;Carta&gt;
        ///		&lt;Titolo&gt;Capitali&lt;/Titolo&gt;
        ///		&lt;Quesito&gt;Qual è la capitale dell&apos;Italia?&lt;/Quesito&gt;
        ///		&lt;Risposte&gt;Roma&lt;/Risposte&gt;
        ///		&lt;Risposte&gt;Milano&lt;/Risposte&gt;
        ///		&lt;Risposte&gt;Napoli&lt;/Risposte&gt;
        ///		&lt;Risposte&gt;Firenze&lt;/Risposte&gt;
        ///		&lt;RispostaCorretta&gt;Roma&lt;/RispostaCorretta&gt;
        ///	&lt;/Carta&gt;
        ///	&lt;Carta&gt;
        ///		&lt;Titolo&gt;Capitali&lt;/Titolo&gt;
        ///		&lt;Quesito&gt;Qual è la capitale della Russia?&lt;/Quesito&gt;
        ///		&lt;Risposte&gt;Mo [stringa troncata]&quot;;.
        /// </summary>
        public static string mazzo_geografia {
            get {
                return ResourceManager.GetString("mazzo_geografia", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Cerca una stringa localizzata simile a &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot; ?&gt;
        ///&lt;Carte&gt;
        ///    &lt;!-- Domande di Astronomia --&gt;
        ///	&lt;TipoMazzo&gt;Scienze&lt;/TipoMazzo&gt;
        ///	&lt;Immagine&gt;&lt;/Immagine&gt;
        ///	&lt;Livello&gt;2&lt;/Livello&gt;
        ///	&lt;Carta&gt;
        ///		&lt;Titolo&gt;Astronomia&lt;/Titolo&gt;
        ///		&lt;Quesito&gt;Cosa causa un&apos;eclissi solare?&lt;/Quesito&gt;
        ///		&lt;Risposte&gt;L&apos;ombra della Luna che cade sulla Terra&lt;/Risposte&gt;
        ///		&lt;Risposte&gt;L&apos;ombra della Terra che cade sulla Luna&lt;/Risposte&gt;
        ///		&lt;Risposte&gt;Un&apos;allineamento di pianeti&lt;/Risposte&gt;
        ///		&lt;Risposte&gt;Un impatto di asteroidi&lt;/Risposte&gt;
        ///		&lt;RispostaCorretta&gt;L&apos;ombr [stringa troncata]&quot;;.
        /// </summary>
        public static string mazzo_scienze {
            get {
                return ResourceManager.GetString("mazzo_scienze", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Cerca una stringa localizzata simile a &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;Carte&gt;
        ///	&lt;TipoMazzo&gt;Sport&lt;/TipoMazzo&gt;
        ///	&lt;Immagine&gt;&lt;/Immagine&gt;
        ///	&lt;Livello&gt;4&lt;/Livello&gt;
        ///	&lt;Carta&gt;
        ///		&lt;Titolo&gt;Calcio&lt;/Titolo&gt;
        ///		&lt;Quesito&gt;In quale città si trova lo stadio Camp Nou, sede del FC Barcelona?&lt;/Quesito&gt;
        ///		&lt;Risposte&gt;Madrid&lt;/Risposte&gt;
        ///		&lt;Risposte&gt;Barcellona&lt;/Risposte&gt;
        ///		&lt;Risposte&gt;Milano&lt;/Risposte&gt;
        ///		&lt;Risposte&gt;Londra&lt;/Risposte&gt;
        ///		&lt;RispostaCorretta&gt;Barcellona&lt;/RispostaCorretta&gt;
        ///	&lt;/Carta&gt;
        ///	&lt;Carta&gt;
        ///		&lt;Titolo&gt;Basket&lt;/Titolo&gt;
        ///		&lt;Quesito&gt;Qual è la squadra pi [stringa troncata]&quot;;.
        /// </summary>
        public static string mazzo_sport {
            get {
                return ResourceManager.GetString("mazzo_sport", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Cerca una stringa localizzata simile a &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;Carte&gt;
        ///	&lt;!-- Domande sugli Eventi storici --&gt;
        ///	&lt;TipoMazzo&gt;Storia&lt;/TipoMazzo&gt;
        ///	&lt;Immagine&gt;&lt;/Immagine&gt;
        ///	&lt;Livello&gt;5&lt;/Livello&gt;
        ///	&lt;Carta&gt;
        ///		&lt;Titolo&gt;Eventi storici&lt;/Titolo&gt;
        ///		&lt;Quesito&gt;Quando è iniziata la Prima Guerra Mondiale?&lt;/Quesito&gt;
        ///		&lt;Risposte&gt;1914&lt;/Risposte&gt;
        ///		&lt;Risposte&gt;1917&lt;/Risposte&gt;
        ///		&lt;Risposte&gt;1919&lt;/Risposte&gt;
        ///		&lt;Risposte&gt;1939&lt;/Risposte&gt;
        ///		&lt;RispostaCorretta&gt;1914&lt;/RispostaCorretta&gt;
        ///	&lt;/Carta&gt;
        ///	&lt;Carta&gt;
        ///		&lt;Titolo&gt;Personaggi storici&lt;/Titolo&gt;
        ///		&lt;Quesito&gt; [stringa troncata]&quot;;.
        /// </summary>
        public static string mazzo_storia {
            get {
                return ResourceManager.GetString("mazzo_storia", resourceCulture);
            }
        }
    }
}
