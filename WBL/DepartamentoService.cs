using DB;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public class DepartamentoService
    {
        private readonly IDataAccess sql;

        public DepartamentoService(IDataAccess _sql)
        {
            sql = _sql;
        }
        public async Task<IEnumerable<DepartamentoEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<DepartamentoEntity>("DepartamentoObtener");
                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<DepartamentoEntity> GetById(DepartamentoEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<DepartamentoEntity>("DepartamentoObtener", new
                {
                    entity.Id_Departamento
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<DBEntity> Create(DepartamentoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("DepartamentoInsertar", new
                {
                    entity.Descripcion,
                    entity.Ubicacion,
                    entity.Estado
                });

                return await result;
            }
            catch (Exception)
            {
                throw;
            }


        }

        public async Task<DBEntity> Update(DepartamentoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("DepartamentoActualizar", new
                {
                    entity.Id_Departamento,
                    entity.Descripcion,
                    entity.Ubicacion,
                    entity.Estado
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<DBEntity> Delete(DepartamentoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("DepartamentoEliminar", new
                {
                    entity.Id_Departamento
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
