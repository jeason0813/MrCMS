using MrCMS.Data;
using MrCMS.Indexing.Management;
using MrCMS.Indexing.Querying;
using MrCMS.Services;
using Ninject.Modules;
using Ninject.Web.Common;

namespace MrCMS.IoC.Modules
{
    public class GenericBindingsModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind(typeof(ITokenProvider<>)).To(typeof(PropertyTokenProvider<>)).InRequestScope();
            Kernel.Bind(typeof(IMessageParser<,>)).To(typeof(MessageParser<,>)).InRequestScope();
            Kernel.Bind(typeof(IMessageParser<>)).To(typeof(MessageParser<>)).InRequestScope();
            Kernel.Bind(typeof(IIndexManager<,>)).To(typeof(IndexManager<,>)).InRequestScope();
            Kernel.Bind(typeof(ISearcher<,>)).To(typeof(Searcher<,>)).InRequestScope();
            Kernel.Bind(typeof(IRepository<>)).To(typeof(SimpleRepository<>)).InRequestScope();
            Kernel.Bind(typeof(IGetDocumentByUrl<>)).To(typeof(GetDocumentByUrl<>)).InRequestScope();
            Kernel.Bind(typeof(IGetDocumentsByParent<>)).To(typeof(GetDocumentsByParent<>)).InRequestScope();
        }
    }
}