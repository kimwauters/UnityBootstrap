//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public GameActiveRemovedListenerComponent gameActiveRemovedListener { get { return (GameActiveRemovedListenerComponent)GetComponent(GameComponentsLookup.GameActiveRemovedListener); } }
    public bool hasGameActiveRemovedListener { get { return HasComponent(GameComponentsLookup.GameActiveRemovedListener); } }

    public void AddGameActiveRemovedListener(System.Collections.Generic.List<IGameActiveRemovedListener> newValue) {
        var index = GameComponentsLookup.GameActiveRemovedListener;
        var component = CreateComponent<GameActiveRemovedListenerComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGameActiveRemovedListener(System.Collections.Generic.List<IGameActiveRemovedListener> newValue) {
        var index = GameComponentsLookup.GameActiveRemovedListener;
        var component = CreateComponent<GameActiveRemovedListenerComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGameActiveRemovedListener() {
        RemoveComponent(GameComponentsLookup.GameActiveRemovedListener);
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

    static Entitas.IMatcher<GameEntity> _matcherGameActiveRemovedListener;

    public static Entitas.IMatcher<GameEntity> GameActiveRemovedListener {
        get {
            if (_matcherGameActiveRemovedListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GameActiveRemovedListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGameActiveRemovedListener = matcher;
            }

            return _matcherGameActiveRemovedListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddGameActiveRemovedListener(IGameActiveRemovedListener value) {
        var listeners = hasGameActiveRemovedListener
            ? gameActiveRemovedListener.value
            : new System.Collections.Generic.List<IGameActiveRemovedListener>();
        listeners.Add(value);
        ReplaceGameActiveRemovedListener(listeners);
    }

    public void RemoveGameActiveRemovedListener(IGameActiveRemovedListener value, bool removeComponentWhenEmpty = true) {
        var listeners = gameActiveRemovedListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveGameActiveRemovedListener();
        } else {
            ReplaceGameActiveRemovedListener(listeners);
        }
    }
}
