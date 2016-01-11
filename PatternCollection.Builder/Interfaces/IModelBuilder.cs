namespace PatternCollection.Builder.Interfaces
{
    public interface IModelBuilder<TModel>
    {
        TModel ToBuilder();
    }
}
