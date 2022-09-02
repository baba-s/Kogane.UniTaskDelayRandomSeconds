using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Kogane
{
    /// <summary>
    /// UniTask.DelayRandomSeconds に関する拡張メソッドを管理するクラス
    /// </summary>
    public static class UniTaskDelayRandomSecondsExtensionMethods
    {
        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// ランダムな秒数待機します
        /// </summary>
        public static UniTask DelayRandomSeconds
        (
            this GameObject  self,
            float            maxInclusive,
            bool             ignoreTimeScale = false,
            PlayerLoopTiming delayTiming     = PlayerLoopTiming.Update
        )
        {
            return UniTask.DelayRandomSeconds
            (
                gameObject: self,
                maxInclusive: maxInclusive,
                ignoreTimeScale: ignoreTimeScale,
                delayTiming: delayTiming
            );
        }

        /// <summary>
        /// ランダムな秒数待機します
        /// </summary>
        public static UniTask DelayRandomSeconds
        (
            this Component   self,
            float            maxInclusive,
            bool             ignoreTimeScale = false,
            PlayerLoopTiming delayTiming     = PlayerLoopTiming.Update
        )
        {
            return UniTask.DelayRandomSeconds
            (
                component: self,
                maxInclusive: maxInclusive,
                ignoreTimeScale: ignoreTimeScale,
                delayTiming: delayTiming
            );
        }

        /// <summary>
        /// ランダムな秒数待機します
        /// </summary>
        public static UniTask DelayRandomSeconds
        (
            this GameObject  self,
            float            maxInclusive,
            DelayType        delayType,
            PlayerLoopTiming delayTiming = PlayerLoopTiming.Update
        )
        {
            return UniTask.DelayRandomSeconds
            (
                gameObject: self,
                maxInclusive: maxInclusive,
                delayType: delayType,
                delayTiming: delayTiming
            );
        }

        /// <summary>
        /// ランダムな秒数待機します
        /// </summary>
        public static UniTask DelayRandomSeconds
        (
            this Component   self,
            float            maxInclusive,
            DelayType        delayType,
            PlayerLoopTiming delayTiming = PlayerLoopTiming.Update
        )
        {
            return UniTask.DelayRandomSeconds
            (
                component: self,
                maxInclusive: maxInclusive,
                delayType: delayType,
                delayTiming: delayTiming
            );
        }

        /// <summary>
        /// ランダムな秒数待機します
        /// </summary>
        public static UniTask DelayRandomSeconds
        (
            this GameObject  self,
            float            minInclusive,
            float            maxInclusive,
            bool             ignoreTimeScale = false,
            PlayerLoopTiming delayTiming     = PlayerLoopTiming.Update
        )
        {
            return UniTask.DelayRandomSeconds
            (
                gameObject: self,
                minInclusive: minInclusive,
                maxInclusive: maxInclusive,
                ignoreTimeScale: ignoreTimeScale,
                delayTiming: delayTiming
            );
        }

        /// <summary>
        /// ランダムな秒数待機します
        /// </summary>
        public static UniTask DelayRandomSeconds
        (
            this Component   self,
            float            minInclusive,
            float            maxInclusive,
            bool             ignoreTimeScale = false,
            PlayerLoopTiming delayTiming     = PlayerLoopTiming.Update
        )
        {
            return UniTask.DelayRandomSeconds
            (
                component: self,
                minInclusive: minInclusive,
                maxInclusive: maxInclusive,
                ignoreTimeScale: ignoreTimeScale,
                delayTiming: delayTiming
            );
        }

        /// <summary>
        /// ランダムな秒数待機します
        /// </summary>
        public static UniTask DelayRandomSeconds
        (
            this GameObject  self,
            float            minInclusive,
            float            maxInclusive,
            DelayType        delayType,
            PlayerLoopTiming delayTiming = PlayerLoopTiming.Update
        )
        {
            return UniTask.DelayRandomSeconds
            (
                gameObject: self,
                minInclusive: minInclusive,
                maxInclusive: maxInclusive,
                delayType: delayType,
                delayTiming: delayTiming
            );
        }

        /// <summary>
        /// ランダムな秒数待機します
        /// </summary>
        public static UniTask DelayRandomSeconds
        (
            this Component   self,
            float            minInclusive,
            float            maxInclusive,
            DelayType        delayType,
            PlayerLoopTiming delayTiming = PlayerLoopTiming.Update
        )
        {
            return UniTask.DelayRandomSeconds
            (
                component: self,
                minInclusive: minInclusive,
                maxInclusive: maxInclusive,
                delayType: delayType,
                delayTiming: delayTiming
            );
        }
    }
}