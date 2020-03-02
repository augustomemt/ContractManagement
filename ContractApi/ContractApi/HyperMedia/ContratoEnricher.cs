using ContractApi.Data.VO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tapioca.HATEOAS;

namespace ContractApi.HyperMedia
{
    public class ContratoEnricher : ObjectContentResponseEnricher<ContratosVO>
    {
        protected override Task EnrichModel(ContratosVO content, IUrlHelper urlHelper)
        {
            var path = "api/Contratos/v1.0";
            var url = new { controller = path, id = content.Id };

            content.Links.Add(new HyperMediaLink()
            {

                Action = HttpActionVerb.GET,
                Href = urlHelper.Link("Defaut", url),
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultGet

            });
            content.Links.Add(new HyperMediaLink()
            {

                Action = HttpActionVerb.POST,
                Href = urlHelper.Link("Defaut", url),
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultPost

            });
            content.Links.Add(new HyperMediaLink()
            {

                Action = HttpActionVerb.PUT,
                Href = urlHelper.Link("Defaut", url),
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultPost

            });
            content.Links.Add(new HyperMediaLink()
            {

                Action = HttpActionVerb.DELETE,
                Href = urlHelper.Link("Defaut", url),
                Rel = RelationType.self,
                Type = "int"

            });

            return null;
        }
    }
}
