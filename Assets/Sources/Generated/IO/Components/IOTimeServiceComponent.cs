//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class IOContext {

    public IOEntity timeServiceEntity { get { return GetGroup(IOMatcher.TimeService).GetSingleEntity(); } }
    public TimeServiceComponent timeService { get { return timeServiceEntity.timeService; } }
    public bool hasTimeService { get { return timeServiceEntity != null; } }

    public IOEntity SetTimeService(ITimeService newInstance) {
        if (hasTimeService) {
            throw new Entitas.EntitasException("Could not set TimeService!\n" + this + " already has an entity with TimeServiceComponent!",
                "You should check if the context already has a timeServiceEntity before setting it or use context.ReplaceTimeService().");
        }
        var entity = CreateEntity();
        entity.AddTimeService(newInstance);
        return entity;
    }

    public void ReplaceTimeService(ITimeService newInstance) {
        var entity = timeServiceEntity;
        if (entity == null) {
            entity = SetTimeService(newInstance);
        } else {
            entity.ReplaceTimeService(newInstance);
        }
    }

    public void RemoveTimeService() {
        timeServiceEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class IOEntity {

    public TimeServiceComponent timeService { get { return (TimeServiceComponent)GetComponent(IOComponentsLookup.TimeService); } }
    public bool hasTimeService { get { return HasComponent(IOComponentsLookup.TimeService); } }

    public void AddTimeService(ITimeService newInstance) {
        var index = IOComponentsLookup.TimeService;
        var component = CreateComponent<TimeServiceComponent>(index);
        component.instance = newInstance;
        AddComponent(index, component);
    }

    public void ReplaceTimeService(ITimeService newInstance) {
        var index = IOComponentsLookup.TimeService;
        var component = CreateComponent<TimeServiceComponent>(index);
        component.instance = newInstance;
        ReplaceComponent(index, component);
    }

    public void RemoveTimeService() {
        RemoveComponent(IOComponentsLookup.TimeService);
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
public sealed partial class IOMatcher {

    static Entitas.IMatcher<IOEntity> _matcherTimeService;

    public static Entitas.IMatcher<IOEntity> TimeService {
        get {
            if (_matcherTimeService == null) {
                var matcher = (Entitas.Matcher<IOEntity>)Entitas.Matcher<IOEntity>.AllOf(IOComponentsLookup.TimeService);
                matcher.componentNames = IOComponentsLookup.componentNames;
                _matcherTimeService = matcher;
            }

            return _matcherTimeService;
        }
    }
}
