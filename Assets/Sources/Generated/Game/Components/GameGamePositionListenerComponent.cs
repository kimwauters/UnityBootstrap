//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public GamePositionListenerComponent gamePositionListener { get { return (GamePositionListenerComponent)GetComponent(GameComponentsLookup.GamePositionListener); } }
    public bool hasGamePositionListener { get { return HasComponent(GameComponentsLookup.GamePositionListener); } }

    public void AddGamePositionListener(System.Collections.Generic.List<IGamePositionListener> newValue) {
        var index = GameComponentsLookup.GamePositionListener;
        var component = CreateComponent<GamePositionListenerComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGamePositionListener(System.Collections.Generic.List<IGamePositionListener> newValue) {
        var index = GameComponentsLookup.GamePositionListener;
        var component = CreateComponent<GamePositionListenerComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGamePositionListener() {
        RemoveComponent(GameComponentsLookup.GamePositionListener);
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

    static Entitas.IMatcher<GameEntity> _matcherGamePositionListener;

    public static Entitas.IMatcher<GameEntity> GamePositionListener {
        get {
            if (_matcherGamePositionListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GamePositionListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGamePositionListener = matcher;
            }

            return _matcherGamePositionListener;
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

    public void AddGamePositionListener(IGamePositionListener value) {
        var listeners = hasGamePositionListener
            ? gamePositionListener.value
            : new System.Collections.Generic.List<IGamePositionListener>();
        listeners.Add(value);
        ReplaceGamePositionListener(listeners);
    }

    public void RemoveGamePositionListener(IGamePositionListener value, bool removeComponentWhenEmpty = true) {
        var listeners = gamePositionListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveGamePositionListener();
        } else {
            ReplaceGamePositionListener(listeners);
        }
    }
}