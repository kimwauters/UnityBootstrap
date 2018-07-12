//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UIEntity {

    public PositionComponent position { get { return (PositionComponent)GetComponent(UIComponentsLookup.Position); } }
    public bool hasPosition { get { return HasComponent(UIComponentsLookup.Position); } }

    public void AddPosition(UnityEngine.Vector2 newValue) {
        var index = UIComponentsLookup.Position;
        var component = CreateComponent<PositionComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePosition(UnityEngine.Vector2 newValue) {
        var index = UIComponentsLookup.Position;
        var component = CreateComponent<PositionComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePosition() {
        RemoveComponent(UIComponentsLookup.Position);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UIEntity : IPositionEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class UIMatcher {

    static Entitas.IMatcher<UIEntity> _matcherPosition;

    public static Entitas.IMatcher<UIEntity> Position {
        get {
            if (_matcherPosition == null) {
                var matcher = (Entitas.Matcher<UIEntity>)Entitas.Matcher<UIEntity>.AllOf(UIComponentsLookup.Position);
                matcher.componentNames = UIComponentsLookup.componentNames;
                _matcherPosition = matcher;
            }

            return _matcherPosition;
        }
    }
}
