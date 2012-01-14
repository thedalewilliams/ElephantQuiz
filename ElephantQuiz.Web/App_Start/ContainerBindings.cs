using System;
using System.Security.Principal;
using System.Web;
using Ninject;
using Ninject.Modules;
using Raven.Client;
using Raven.Client.Document;

namespace ElephantQuiz.Web.App_Start
{
    public class ContainerBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IDocumentStore>().ToMethod(x => DocumentStoreContainer.DocumentStore).InSingletonScope();
            Bind<IDocumentSession>()
                .ToMethod(e =>
                          DocumentStoreContainer.DocumentStore.OpenSession()
                )
                .InRequestScope()
                .OnDeactivation((ctx, session) =>
                                    {
                                        using (session)
                                        {
                                            session.SaveChanges();
                                        }
                                    }
                );

            Bind<IPrincipal>().ToMethod(context => HttpContext.Current.User);
        }
    }
}