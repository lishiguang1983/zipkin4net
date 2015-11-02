﻿using Criteo.Profiling.Tracing.Annotation;
using NUnit.Framework;

namespace Criteo.Profiling.Tracing.UTest
{
    [TestFixture]
    class T_Annotations
    {

        [Test]
        public void FactoryReturnsCorrectTypes()
        {
            Assert.IsInstanceOf<BinaryAnnotation>(Annotations.Binary("",""));
            Assert.IsInstanceOf<ClientRecv>(Annotations.ClientRecv());
            Assert.IsInstanceOf<ClientSend>(Annotations.ClientSend());
            Assert.IsInstanceOf<LocalAddr>(Annotations.LocalAddr(null));
            Assert.IsInstanceOf<Rpc>(Annotations.Rpc(""));
            Assert.IsInstanceOf<ServerRecv>(Annotations.ServerRecv());
            Assert.IsInstanceOf<ServerSend>(Annotations.ServerSend());
            Assert.IsInstanceOf<ServiceName>(Annotations.ServiceName(""));
        }

    }
}