﻿using Couchbase.Core;

using Stove.Bootstrapping;
using Stove.Couchbase.Configuration;

namespace Stove.Couchbase
{
    public class StoveCouchbaseBootstrapper : StoveBootstrapper
    {
        public override void PreStart()
        {
            StoveConfiguration.GetConfigurerIfExists<IStoveCouchbaseConfiguration>()(StoveConfiguration.Modules.StoveCouchbase());
        }

        public override void Shutdown()
        {
            Resolver.Resolve<ICluster>().Dispose();
        }
    }
}
