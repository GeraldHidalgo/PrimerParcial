using DB;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IPuestoService
    {
        Task<DBEntity> Create(PuestoEntity entity);
        Task<DBEntity> Delete(PuestoEntity entity);
        Task<IEnumerable<PuestoEntity>> Get();
        Task<PuestoEntity> GetById(PuestoEntity entity);
        Task<DBEntity> Update(PuestoEntity entity);
    }
    public class PuestoService:IPuestoService
    {
        private readonly IDataAccess sql;

        public PuestoService(IDataAccess _sql)
        {
            sql = _sql;
        }
        public async Task<IEnumerable<PuestoEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<PuestoEntity>("PuestoObtener");
                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<PuestoEntity> GetById(PuestoEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<PuestoEntity>("PuestoObtener", new
                {
                    entity.Id_Puesto
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<DBEntity> Create(PuestoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("PuestoInsertar", new
                {
                    entity.Nombre,
                    entity.Salario,
                    entity.Estado
                });

                return await result;
            }
            catch (Exception)
            {
                throw;
            }


        }

        public async Task<DBEntity> Update(PuestoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("PuestoActualizar", new
                {
                    entity.Id_Puesto,
                    entity.Nombre,
                    entity.Salario,
                    entity.Estado
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<DBEntity> Delete(PuestoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("PuestoEliminar", new
                {
                    entity.Id_Puesto
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
