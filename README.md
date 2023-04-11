This repository demonstrates how to use the pooling library available at **[https://github.com/Zitga-Tech/ZBase.Foundation.Pooling.git](https://github.com/Zitga-Tech/ZBase.Foundation.Pooling.git)**.

## **Project Structure**

```
.
└── Assets/
    ├── AddressableAssetsData
    ├── Characters
    ├── Environment
    └── PoolSample/
        ├── AddressablePools
        ├── ComponentPools
        ├── GameObjectPools
        └── ScriptablePools
```

The project structure contains the following folders:

- **`AddressableAssetsData`**: contains the settings of Addressables which are used to demonstrate Addressable pooling.
- **`Characters`**: contains some 3D characters that are used in the demo.
- **`Environment`**: contains the implementation of a simple grid environment.
- **`PoolSample/`**: contains the samples for all types of pools.

## **Definition**

There are three types of pool, which are:

- C# object
- MonoBehaviour
- ScriptableObject

A pool needs the following properties to work:

- Prefab: a data type inherited from **`IPrefab`**.
- Source: where the Unity prefab can be loaded. There are three types of source:
    - Source from direct reference: you can drag and drop an asset in the Inspector.
    - Source from Addressable **`AssetReference`**: you can search and select the reference to the addressed asset in the Inspector.
    - Source from Addressable key: you can load the asset from a string key.
    - Alternatively, you can set the source for the prefab at runtime.
- Parent (optional): the parent game object of the pool’s child.

In this demo, we have created examples for all types of pools, and all types of sources mentioned above.