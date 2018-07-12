//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public SortingLayerComponent sortingLayer { get { return (SortingLayerComponent)GetComponent(GameComponentsLookup.SortingLayer); } }
    public bool hasSortingLayer { get { return HasComponent(GameComponentsLookup.SortingLayer); } }

    public void AddSortingLayer(string newValue) {
        var index = GameComponentsLookup.SortingLayer;
        var component = CreateComponent<SortingLayerComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceSortingLayer(string newValue) {
        var index = GameComponentsLookup.SortingLayer;
        var component = CreateComponent<SortingLayerComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveSortingLayer() {
        RemoveComponent(GameComponentsLookup.SortingLayer);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherSortingLayer;

    public static Entitas.IMatcher<GameEntity> SortingLayer {
        get {
            if (_matcherSortingLayer == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SortingLayer);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSortingLayer = matcher;
            }

            return _matcherSortingLayer;
        }
    }
}