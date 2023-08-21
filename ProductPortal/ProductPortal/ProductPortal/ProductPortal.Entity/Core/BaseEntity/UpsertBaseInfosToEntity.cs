using ProductPortal.Core.CurrentUserDtos;

namespace ProductPortal.Entity.Core.BaseEntity
{
    public static class UpsertBaseInfosToEntity<T> where T : BaseEntity
    {
        public static T ForInsert(T entity, CurrentUserDto currentUser, bool isActiveSetTrue = true)
        {
            entity.CreatedDate = DateTime.Now;
            entity.CreatedUser = currentUser != null ? currentUser.KullaniciId.Value : Guid.Empty;

            if (isActiveSetTrue)
                entity.IsActive = true;

            return entity;
        }

        public static T ForUpdate(T entity, CurrentUserDto currentUser, bool isActiveSetTrue = true)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.UpdatedUser = currentUser.KullaniciId.Value;

            if (isActiveSetTrue)
                entity.IsActive = true;

            return entity;
        }

        public static List<T> ForInsertRange(List<T> entityList, CurrentUserDto currentUser, bool isActiveSetTrue = true)
        {
            List<T> result = new();
            foreach (T entity in entityList)
            {
                result.Add(ForInsert(entity, currentUser, isActiveSetTrue));
            }
            return result;
        }
    }
}
