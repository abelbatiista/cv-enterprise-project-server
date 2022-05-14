namespace Server.Core.BaseModels
{
    #region AuditableEntity
    public interface IAuditableEntity : ICreatebleEntity, IUpdatebleEntity, IDeletableEntity { }
    public class AuditableEntity : IAuditableEntity, IBaseEntity
    {
        public virtual int Id { get; set; }
        public virtual DateTimeOffset CreatedDate { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual bool Updated { get; set; }
        public virtual DateTimeOffset? UpdatedDate { get; set; }
        public virtual string UpdatedBy { get; set; }
        public virtual bool Deleted { get; set; }
        public virtual DateTimeOffset? DeletedDate { get; set; }
        public virtual string DeletedBy { get; set; }
    }

    #endregion

    #region AuditableEntityDto
    public interface IAuditableEntityDto : ICreatebleEntityDto, IUpdatebleEntityDto, IDeletableEntityDto { }
    public class AuditableEntityDto : IAuditableEntityDto, IBaseEntityDto
    {
        public virtual int? Id { get; set; }
        public virtual DateTimeOffset? CreatedDate { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual bool Updated { get; set; }
        public virtual DateTimeOffset? UpdatedDate { get; set; }
        public virtual string UpdatedBy { get; set; }
        public virtual bool Deleted { get; set; }
        public virtual DateTimeOffset? DeletedDate { get; set; }
        public virtual string DeletedBy { get; set; }
    }
    #endregion
}
