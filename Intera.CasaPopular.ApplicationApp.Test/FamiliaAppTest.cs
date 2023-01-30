using ApplicationApp.App;
using ApplicationApp.Interfaces;
using Domain.Interfaces;
using Entities.Entities;
using Intera.CasaPopular.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Intera.CasaPopular.ApplicationApp.Test
{
    public class FamiliaAppTest
    {
        IFamilia _IFamilia;
        FamiliaApp _FamiliaApp;
        IFamiliaApp _IFamiliaApp;
        IFamiliaService _IFamiliaService;

        public FamiliaAppTest()
        {
            _IFamiliaApp = new FamiliaAppMock();
            _FamiliaApp = new FamiliaApp(_IFamilia, _IFamiliaService);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsFamiliasPorCriterio()
        {
            var okResult = _FamiliaApp.FamiliasPorCriterio();
            var items = Assert.IsType<List<FamiliaAppMock>>(okResult);
            Assert.Equal(okResult.Count, items.Count);
        }
    }
}
