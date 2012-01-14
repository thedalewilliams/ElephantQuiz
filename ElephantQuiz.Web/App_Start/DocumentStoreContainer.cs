using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Raven.Client;
using Raven.Client.Document;

namespace ElephantQuiz.Web.App_Start
{
    public static class DocumentStoreContainer
    {
        private static readonly Lazy<IDocumentStore> documentStore = new Lazy<IDocumentStore>(() => new DocumentStore
                                                                                                {
                                                                                                    ConnectionStringName
                                                                                                        = "RavenDB",
                                                                                                }.Initialize());
        public static IDocumentStore DocumentStore
        {
            get { return documentStore.Value; }
        }
    }
}