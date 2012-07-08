﻿using System.Collections.Generic;
using Mono.Cecil;

public class TypeNode
{
    public TypeNode()
    {
        Nodes = new List<TypeNode>();
        PropertyDependencies = new List<PropertyDependency>();
        Mappings = new List<MemberMapping>();
        PropertyDatas = new List<PropertyData>();
    }

    public TypeDefinition TypeDefinition;
    public List<TypeNode> Nodes;
    public List<PropertyDependency> PropertyDependencies;
    public List<MemberMapping> Mappings;
    public EventInvokerMethod EventInvoker;
    public MethodReference IsChangedInvoker;
    public bool ShouldNotifyForAllInType;
    public List<PropertyData> PropertyDatas;
    public List<MethodReference> OnChangedMethods;
    public List<PropertyDefinition> AllProperties;
}