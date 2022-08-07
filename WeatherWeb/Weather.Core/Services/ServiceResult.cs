using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.DAL.Interfaces;

namespace Weather.Core.Services
{
    public class ServiceResult
    {
        private List<string> errors = new List<string>();
        public IEnumerable<string> Errors => errors;

        private bool? _succeeded;
        public bool Succeeded => _succeeded ?? !errors.Any();

        private IEntity _entity;
        public IEntity Entity => _entity;

        public ServiceResult() { }

        public ServiceResult(IEnumerable<string> errors)
        {
            Set(errors);
        }

        public ServiceResult(params string[] errors)
        {
            Set(errors);
        }

        public ServiceResult(bool success)
        {
            this._succeeded = success;
        }

        #region Fluent

        public ServiceResult Add(IEnumerable<string> errors)
        {
            foreach (string err in errors)
            {
                if (!string.IsNullOrEmpty(err))
                    this.errors.Add(err);
            }

            return this;
        }

        public ServiceResult Add(params string[] errors)
        {
            foreach (string err in errors)
            {
                if (!string.IsNullOrEmpty(err))
                    this.errors.Add(err);
            }

            return this;
        }

        public ServiceResult Set(IEnumerable<string> errors)
        {
            this.errors.Clear();
            Add(errors);

            return this;
        }

        public ServiceResult Set(params string[] errors)
        {
            this.errors.Clear();
            Add(errors);

            return this;
        }

        public ServiceResult Set(bool success)
        {
            this._succeeded = success;
            return this;
        }

        public ServiceResult Set(IEntity entity)
        {
            this._entity = entity;
            return this;
        }

        #endregion
    }
}
