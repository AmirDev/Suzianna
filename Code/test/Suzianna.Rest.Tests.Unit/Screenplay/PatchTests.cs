﻿using System.Net.Http;
using NFluent;
using Suzianna.Rest.Screenplay.Interactions;
using Suzianna.Rest.Tests.Unit.TestConstants;
using Suzianna.Rest.Tests.Unit.TestUtils;
using Xunit;

namespace Suzianna.Rest.Tests.Unit.Screenplay
{
    public class PatchTests : HttpInteractionWithContentTests
    {
        protected override HttpMethod GetHttpMethod() => HttpMethod.Patch;
        protected override HttpInteraction GetHttpInteraction(string resource)
        {
            return Patch.DataAsJson(ContentFactory.SomeContent()).To(resource);
        }
        protected override HttpInteraction GetHttpInteractionWithJsonContent(object content)
        {
            return Patch.DataAsJson(content).To(Urls.UsersApi);
        }

        protected override HttpInteraction GetHttpInteractionWithXmlContent(object content)
        {
            return Patch.DataAsXml(content).To(Urls.UsersApi);
        }
    }
}
