namespace ProductPortal.Core.CurrentUserDtos
{
    public class ValueIsExistDto<T>
    {
        public bool IsExist { get; set; }
        public T Value { get; set; }
    }
}
