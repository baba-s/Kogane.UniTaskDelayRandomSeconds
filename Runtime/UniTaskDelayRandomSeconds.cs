using System;
using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks
{
    public partial struct UniTask
    {
        public static UniTask DelayRandomSeconds
        (
            float             maxInclusive,
            bool              ignoreTimeScale   = false,
            PlayerLoopTiming  delayTiming       = PlayerLoopTiming.Update,
            CancellationToken cancellationToken = default
        )
        {
            return Delay
            (
                delayTimeSpan: TimeSpan.FromSeconds( UnityEngine.Random.Range( 0, maxInclusive ) ),
                ignoreTimeScale: ignoreTimeScale,
                delayTiming: delayTiming,
                cancellationToken: cancellationToken
            );
        }

        public static UniTask DelayRandomSeconds
        (
            float             maxInclusive,
            DelayType         delayType,
            PlayerLoopTiming  delayTiming       = PlayerLoopTiming.Update,
            CancellationToken cancellationToken = default
        )
        {
            return Delay
            (
                delayTimeSpan: TimeSpan.FromSeconds( UnityEngine.Random.Range( 0, maxInclusive ) ),
                delayType: delayType,
                delayTiming: delayTiming,
                cancellationToken: cancellationToken
            );
        }

        public static UniTask DelayRandomSeconds
        (
            GameObject       gameObject,
            float            maxInclusive,
            bool             ignoreTimeScale = false,
            PlayerLoopTiming delayTiming     = PlayerLoopTiming.Update
        )
        {
            return DelayRandomSeconds
            (
                maxInclusive: maxInclusive,
                ignoreTimeScale: ignoreTimeScale,
                delayTiming: delayTiming,
                cancellationToken: gameObject.GetCancellationTokenOnDestroy()
            );
        }

        public static UniTask DelayRandomSeconds
        (
            GameObject       gameObject,
            float            maxInclusive,
            DelayType        delayType,
            PlayerLoopTiming delayTiming = PlayerLoopTiming.Update
        )
        {
            return DelayRandomSeconds
            (
                maxInclusive: maxInclusive,
                delayType: delayType,
                delayTiming: delayTiming,
                cancellationToken: gameObject.GetCancellationTokenOnDestroy()
            );
        }

        public static UniTask DelayRandomSeconds
        (
            Component        component,
            float            maxInclusive,
            bool             ignoreTimeScale = false,
            PlayerLoopTiming delayTiming     = PlayerLoopTiming.Update
        )
        {
            return DelayRandomSeconds
            (
                gameObject: component.gameObject,
                maxInclusive: maxInclusive,
                ignoreTimeScale: ignoreTimeScale,
                delayTiming: delayTiming
            );
        }

        public static UniTask DelayRandomSeconds
        (
            Component        component,
            float            maxInclusive,
            DelayType        delayType,
            PlayerLoopTiming delayTiming = PlayerLoopTiming.Update
        )
        {
            return DelayRandomSeconds
            (
                gameObject: component.gameObject,
                maxInclusive: maxInclusive,
                delayType: delayType,
                delayTiming: delayTiming
            );
        }

        public static UniTask DelayRandomSeconds
        (
            float             minInclusive,
            float             maxInclusive,
            bool              ignoreTimeScale   = false,
            PlayerLoopTiming  delayTiming       = PlayerLoopTiming.Update,
            CancellationToken cancellationToken = default
        )
        {
            return Delay
            (
                delayTimeSpan: TimeSpan.FromSeconds( UnityEngine.Random.Range( minInclusive, maxInclusive ) ),
                ignoreTimeScale: ignoreTimeScale,
                delayTiming: delayTiming,
                cancellationToken: cancellationToken
            );
        }

        public static UniTask DelayRandomSeconds
        (
            float             minInclusive,
            float             maxInclusive,
            DelayType         delayType,
            PlayerLoopTiming  delayTiming       = PlayerLoopTiming.Update,
            CancellationToken cancellationToken = default
        )
        {
            return Delay
            (
                delayTimeSpan: TimeSpan.FromSeconds( UnityEngine.Random.Range( minInclusive, maxInclusive ) ),
                delayType: delayType,
                delayTiming: delayTiming,
                cancellationToken: cancellationToken
            );
        }

        public static UniTask DelayRandomSeconds
        (
            GameObject       gameObject,
            float            minInclusive,
            float            maxInclusive,
            bool             ignoreTimeScale = false,
            PlayerLoopTiming delayTiming     = PlayerLoopTiming.Update
        )
        {
            return DelayRandomSeconds
            (
                minInclusive: minInclusive,
                maxInclusive: maxInclusive,
                ignoreTimeScale: ignoreTimeScale,
                delayTiming: delayTiming,
                cancellationToken: gameObject.GetCancellationTokenOnDestroy()
            );
        }

        public static UniTask DelayRandomSeconds
        (
            GameObject       gameObject,
            float            minInclusive,
            float            maxInclusive,
            DelayType        delayType,
            PlayerLoopTiming delayTiming = PlayerLoopTiming.Update
        )
        {
            return DelayRandomSeconds
            (
                minInclusive: minInclusive,
                maxInclusive: maxInclusive,
                delayType: delayType,
                delayTiming: delayTiming,
                cancellationToken: gameObject.GetCancellationTokenOnDestroy()
            );
        }

        public static UniTask DelayRandomSeconds
        (
            Component        component,
            float            minInclusive,
            float            maxInclusive,
            bool             ignoreTimeScale = false,
            PlayerLoopTiming delayTiming     = PlayerLoopTiming.Update
        )
        {
            return DelayRandomSeconds
            (
                gameObject: component.gameObject,
                minInclusive: minInclusive,
                maxInclusive: maxInclusive,
                ignoreTimeScale: ignoreTimeScale,
                delayTiming: delayTiming
            );
        }

        public static UniTask DelayRandomSeconds
        (
            Component        component,
            float            minInclusive,
            float            maxInclusive,
            DelayType        delayType,
            PlayerLoopTiming delayTiming = PlayerLoopTiming.Update
        )
        {
            return DelayRandomSeconds
            (
                gameObject: component.gameObject,
                minInclusive: minInclusive,
                maxInclusive: maxInclusive,
                delayType: delayType,
                delayTiming: delayTiming
            );
        }
    }
}