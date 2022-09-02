# Kogane UniTask Delay Random Seconds

UniTask.DelayRandomSeconds を使えるようにするパッケージ

## 使用例

### Before

```csharp
using System;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Random = UnityEngine.Random;

public class Example : MonoBehaviour
{
    private async UniTaskVoid Start()
    {
        await UniTask.Delay( TimeSpan.FromSeconds( Random.Range( 0, 10 ) ) );

        await UniTask.Delay
        (
            TimeSpan.FromSeconds( Random.Range( 0, 10 ) ),
            cancellationToken: gameObject.GetCancellationTokenOnDestroy()
        );
    }
}
```

### After

```csharp
using Cysharp.Threading.Tasks;
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private async UniTaskVoid Start()
    {
        await UniTask.DelayRandomSeconds( 10 );
        await UniTask.DelayRandomSeconds( 0, 10 );
        await gameObject.DelayRandomSeconds( 10 );
        await gameObject.DelayRandomSeconds( 0, 10 );
        await this.DelayRandomSeconds( 10 );
        await this.DelayRandomSeconds( 0, 10 );
    }
}
```