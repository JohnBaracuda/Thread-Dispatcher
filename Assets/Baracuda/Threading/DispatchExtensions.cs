﻿using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace Baracuda.Threading
{
    public static class DispatchExtensions
    {
        
        #region --- [ACTION] ---

        
        /// <summary>
        /// Dispatch the execution of an <see cref="Action"/> to the main thread.
        /// Actions are by default executed during the next available<br/>
        /// Update, FixedUpdate, LateUpdate or Tick cycle.<br/>
        /// Use <see cref="Dispatcher.Invoke(System.Action, ExecutionCycle)"/> 
        /// for more control over the cycle in which the dispatched <see cref="Action"/> is executed.
        /// </summary>
        /// <param name="action"><see cref="Action"/> dispatched action.</param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#actions-ext">Documentation</a></footer>
        public static void Dispatch(this Action action)
        {
            Dispatcher.Invoke(action);
        }
        
        /// <summary>
        /// Dispatch the execution of an <see cref="Action"/> to the main thread.
        /// Actions are by default executed during the next available<br/>
        /// Update, FixedUpdate, LateUpdate or Tick cycle.<br/>
        /// Use <see cref="Dispatcher.Invoke(System.Action, ExecutionCycle)"/> 
        /// for more control over the cycle in which the dispatched <see cref="Action"/> is executed.
        /// </summary>
        /// <param name="action"><see cref="Action"/> dispatched action.</param>
        /// <param name="arg">first argument</param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#actions-ext">Documentation</a></footer>
        public static void Dispatch<T>(this Action<T> action, T arg)
        {
            Dispatcher.Invoke(() => action(arg));
        }
        
        /// <summary>
        /// Dispatch the execution of an <see cref="Action"/> to the main thread.
        /// Actions are by default executed during the next available<br/>
        /// Update, FixedUpdate, LateUpdate or Tick cycle.<br/>
        /// Use <see cref="Dispatcher.Invoke(System.Action, ExecutionCycle)"/> 
        /// for more control over the cycle in which the dispatched <see cref="Action"/> is executed.
        /// </summary>
        /// <param name="action"><see cref="Action"/> dispatched action.</param>
        /// <param name="arg1">first argument</param>
        /// <param name="arg2">second argument</param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#actions-ext">Documentation</a></footer>
        public static void Dispatch<T, S>(this Action<T, S> action, T arg1, S arg2)
        {
            Dispatcher.Invoke(() => action(arg1, arg2));
        }
        
        /// <summary>
        /// Dispatch the execution of an <see cref="Action"/> to the main thread.
        /// Actions are by default executed during the next available<br/>
        /// Update, FixedUpdate, LateUpdate or Tick cycle.<br/>
        /// Use <see cref="Dispatcher.Invoke(System.Action, ExecutionCycle)"/> 
        /// for more control over the cycle in which the dispatched <see cref="Action"/> is executed.
        /// </summary>
        /// <param name="action"><see cref="Action"/> dispatched action.</param>
        /// <param name="arg1">first argument</param>
        /// <param name="arg2">second argument</param>
        /// <param name="arg3">third argument</param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#actions-ext">Documentation</a></footer>
        public static void Dispatch<T, S, U>(this Action<T, S, U> action, T arg1, S arg2, U arg3)
        {
            Dispatcher.Invoke(() => action(arg1, arg2, arg3));
        }

        /// <summary>
        /// Dispatch the execution of an <see cref="Action"/> to the main thread.
        /// Actions are by default executed during the next available<br/>
        /// Update, FixedUpdate, LateUpdate or Tick cycle.<br/>
        /// Use <see cref="Dispatcher.Invoke(System.Action, ExecutionCycle)"/> 
        /// for more control over the cycle in which the dispatched <see cref="Action"/> is executed.
        /// </summary>
        /// <param name="action"><see cref="Action"/> dispatched action.</param>
        /// <param name="arg1">first argument</param>
        /// <param name="arg2">second argument</param>
        /// <param name="arg3">third argument</param>
        /// <param name="arg4">fourth argument</param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#actions-ext">Documentation</a></footer>
        public static void Dispatch<T, S, U, V>(this Action<T, S, U, V> action, T arg1, S arg2, U arg3, V arg4)
        {
            Dispatcher.Invoke(() => action(arg1, arg2, arg3, arg4));
        }
        
        
        
        /// <summary>
        /// Dispatch an <see cref="Action"/> that will be executed on the main thread and determine the exact cycle,
        /// during which the passed action will be executed.
        /// </summary>
        /// <param name="action"><see cref="Action"/> dispatched action.</param>
        /// <param name="cycle">The execution cycle during which the passed <see cref="Action"/> is executed.</param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#actions-ext">Documentation</a></footer>
        public static void Dispatch(this Action action, ExecutionCycle cycle)
        {
            Dispatcher.Invoke(action, cycle);
        }
        
        /// <summary>
        /// Dispatch an <see cref="Action"/> that will be executed on the main thread and determine the exact cycle,
        /// during which the passed action will be executed.
        /// </summary>
        /// <param name="action"><see cref="Action"/> dispatched action.</param>
        /// <param name="cycle">The execution cycle during which the passed <see cref="Action"/> is executed.</param>
        /// <param name="arg">first argument</param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#actions-ext">Documentation</a></footer>
        public static void Dispatch<T>(this Action<T> action, T arg, ExecutionCycle cycle)
        {
            Dispatcher.Invoke(() => action(arg), cycle);
        }
        
        /// <summary>
        /// Dispatch an <see cref="Action"/> that will be executed on the main thread and determine the exact cycle,
        /// during which the passed action will be executed.
        /// </summary>
        /// <param name="action"><see cref="Action"/> dispatched action.</param>
        /// <param name="cycle">The execution cycle during which the passed <see cref="Action"/> is executed.</param>
        /// <param name="arg1">first argument</param>
        /// <param name="arg2">second argument</param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#actions-ext">Documentation</a></footer>
        public static void Dispatch<T, S>(this Action<T, S> action, T arg1, S arg2, ExecutionCycle cycle)
        {
            Dispatcher.Invoke(() => action(arg1, arg2), cycle);
        }
        
        /// <summary>
        /// Dispatch an <see cref="Action"/> that will be executed on the main thread and determine the exact cycle,
        /// during which the passed action will be executed.
        /// </summary>
        /// <param name="action"><see cref="Action"/> dispatched action.</param>
        /// <param name="cycle">The execution cycle during which the passed <see cref="Action"/> is executed.</param>
        /// <param name="arg1">first argument</param>
        /// <param name="arg2">second argument</param>
        /// <param name="arg3">third argument</param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#actions-ext">Documentation</a></footer>
        public static void Dispatch<T, S, U>(this Action<T, S, U> action, T arg1, S arg2, U arg3, ExecutionCycle cycle)
        {
            Dispatcher.Invoke(() => action(arg1, arg2, arg3), cycle);
        }

        /// <summary>
        /// Dispatch an <see cref="Action"/> that will be executed on the main thread and determine the exact cycle,
        /// during which the passed action will be executed.
        /// </summary>
        /// <param name="action"><see cref="Action"/> dispatched action.</param>
        /// <param name="cycle">The execution cycle during which the passed <see cref="Action"/> is executed.</param>
        /// <param name="arg1">first argument</param>
        /// <param name="arg2">second argument</param>
        /// <param name="arg3">third argument</param>
        /// <param name="arg4">fourth argument</param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#actions-ext">Documentation</a></footer>
        public static void Dispatch<T, S, U, V>(this Action<T, S, U, V> action, T arg1, S arg2, U arg3, V arg4, ExecutionCycle cycle)
        {
            Dispatcher.Invoke(() => action(arg1, arg2, arg3, arg4), cycle);
        }
        
        
        
        /// <summary>
        /// Dispatch an <see cref="Action"/> that will be executed on the main thread and return a <see cref="Task"/>, 
        /// that when awaited on the calling thread, returns after the <see cref="Action"/>
        /// was executed on the main thread.
        /// </summary>
        /// <param name="action"><see cref="Action"/> that will be invoked.</param>
        /// <returns>Task that will complete on the calling thread after the passed action has been executed.</returns>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#actions-ext">Documentation</a></footer>
        public static Task DispatchAsync(this Action action)
        {
            return Dispatcher.InvokeAsync(action);
        }
        
        /// <summary>
        /// Dispatch an <see cref="Action"/> that will be executed on the main thread and return a <see cref="Task"/>, 
        /// that when awaited on the calling thread, returns after the <see cref="Action"/>
        /// was executed on the main thread.
        /// </summary>
        /// <param name="action"><see cref="Action"/> that will be invoked.</param>
        /// <param name="cycle">The execution cycle during which the <see cref="Action"/> will be invoked.</param>
        /// <returns>Task that will complete on the calling thread after the passed action has been executed.</returns>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#actions-ext">Documentation</a></footer>
        public static Task DispatchAsync(this Action action, ExecutionCycle cycle)
        {
            return Dispatcher.InvokeAsync(action, cycle);
        }
        
        /// <summary>
        /// Dispatch an <see cref="Action"/> that will be executed on the main thread and return a <see cref="Task"/>, 
        /// that when awaited on the calling thread, returns after the <see cref="Action"/>
        /// was executed on the main thread.
        /// </summary>
        /// <param name="action"><see cref="Action"/> that will be invoked.</param>
        /// <param name="ct"> optional cancellation token that can be passed to abort the task prematurely.</param>
        /// <param name="throwOnCancellation"></param>
        /// <exception cref="OperationCanceledException"> exception is thrown if the task is cancelled prematurely.</exception>
        /// <returns>Task that will complete on the calling thread after the passed action has been executed.</returns>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#actions-ext">Documentation</a></footer>
        public static Task DispatchAsync(this Action action, CancellationToken ct, bool throwOnCancellation = true)
        {
            return Dispatcher.InvokeAsync(action, ct, throwOnCancellation);
        }
        
        /// <summary>
        /// Dispatch an <see cref="Action"/> that will be executed on the main thread and return a <see cref="Task"/>, 
        /// that when awaited on the calling thread, returns after the <see cref="Action"/>
        /// was executed on the main thread.
        /// </summary>
        /// <param name="action"> <see cref="Action"/> that will be invoked.</param>
        /// <param name="cycle"> the execution cycle during which the passed <see cref="Action"/> is executed.</param>
        /// <param name="ct"> optional cancellation token that can be passed to abort the task prematurely.</param>
        /// <param name="throwOnCancellation"> optional parameter that determines if an <see cref="OperationCanceledException"/>
        /// is thrown if the Task is cancelled prematurely.</param>
        /// <exception cref="OperationCanceledException"> exception is thrown if the task is cancelled prematurely.</exception>
        /// <returns>Task that will complete on the calling thread after the passed action has been executed.</returns>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#actions-ext">Documentation</a></footer>
        public static Task DispatchAsync(this Action action, ExecutionCycle cycle, CancellationToken ct, bool throwOnCancellation = true)
        {
            return Dispatcher.InvokeAsync(action, cycle, ct, throwOnCancellation);
        }

        #endregion

        //--------------------------------------------------------------------------------------------------------------
        
        #region --- [FUNC<TRESULT>] ---

        /// <summary>
        /// Dispatch a <see cref="Func{T}"/> that wil executed on the main thread; and return a <see cref="Task{TResult}"/>,
        /// that when awaited on the calling thread, returns the result of the passed <see cref="Func{T}"/>
        /// after it was executed on the main thread.
        /// </summary>
        /// <param name="func"><see cref="Func{T}"/> delegate that will be executed on the main thread.</param>
        /// <exception cref="OperationCanceledException"> exception is thrown if the task is cancelled prematurely.</exception>
        /// <returns>Task that will complete on the calling thread after the delegate was executed.</returns>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#func-ext">Documentation</a></footer>
        public static Task<TResult> DispatchAsync<TResult>(this Func<TResult> func)
        {
            return Dispatcher.InvokeAsync(func);
        }
        
        /// <summary>
        /// Dispatch a <see cref="Func{T}"/> that wil executed on the main thread; and return a <see cref="Task{TResult}"/>,
        /// that when awaited on the calling thread, returns the result of the passed <see cref="Func{T}"/>
        /// after it was executed on the main thread.
        /// </summary>
        /// <param name="func"><see cref="Func{T}"/> delegate that will be executed on the main thread.</param>
        /// <param name="cycle">The execution cycle during which the passed <see cref="Func{T}"/> is executed.</param>
        /// <returns>Task that will complete on the calling thread after the delegate was executed.</returns>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#func-ext">Documentation</a></footer>
        public static Task<TResult> DispatchAsync<TResult>(this Func<TResult> func, ExecutionCycle cycle)
        {
            return Dispatcher.InvokeAsync(func, cycle);
        }
        
        /// <summary>
        /// Dispatch a <see cref="Func{T}"/> that wil executed on the main thread; and return a <see cref="Task{TResult}"/>,
        /// that when awaited on the calling thread, returns the result of the passed <see cref="Func{T}"/>
        /// after it was executed on the main thread.
        /// </summary>
        /// <param name="func"><see cref="Func{T}"/> delegate that will be executed on the main thread.</param>
        /// <param name="ct"> optional cancellation token that can be passed to abort the task prematurely.</param>
        /// <exception cref="OperationCanceledException"> exception is thrown if the task is cancelled prematurely.</exception>
        /// <returns>Task that will complete on the calling thread after the delegate was executed.</returns>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#func-ext">Documentation</a></footer>
        public static Task<TResult> DispatchAsync<TResult>(this Func<TResult> func, CancellationToken ct)
        {
            return Dispatcher.InvokeAsync(func, ct);
        }
        
        /// <summary>
        /// Dispatch a <see cref="Func{T}"/> that wil executed on the main thread; and return a <see cref="Task{TResult}"/>,
        /// that when awaited on the calling thread, returns the result of the passed <see cref="Func{T}"/>
        /// after it was executed on the main thread.
        /// </summary>
        /// <param name="func"><see cref="Func{T}"/> delegate that will be executed on the main thread.</param>
        /// <param name="cycle">The execution cycle during which the passed <see cref="Func{T}"/> is executed.</param>
        /// <param name="ct"> optional cancellation token that can be passed to abort the task prematurely.</param>
        /// <exception cref="OperationCanceledException"> exception is thrown if the task is cancelled prematurely.</exception>
        /// <returns>Task that will complete on the calling thread after the delegate was executed.</returns>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#func-ext">Documentation</a></footer>
        public static Task<TResult> DispatchAsync<TResult>(this Func<TResult> func, ExecutionCycle cycle, CancellationToken ct)
        {
            return Dispatcher.InvokeAsync(func, cycle, ct);
        }

        #endregion

        //--------------------------------------------------------------------------------------------------------------

        #region --- [COROUTINE] ---

        /// <summary>
        /// Dispatch an <see cref="IEnumerator"/> that will be started and executed as a <see cref="Coroutine"/> on the main thread.
        /// </summary>
        /// <param name="enumerator"><see cref="IEnumerator"/> that is started as a <see cref="Coroutine"/>.</param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#coroutines-ext">Documentation</a></footer>
        public static void Dispatch(this IEnumerator enumerator)
        {
            Dispatcher.Invoke(enumerator);
        }
        
        /// <summary>
        /// Dispatch an <see cref="IEnumerator"/> that will be started and executed as a <see cref="Coroutine"/> on the main thread.
        /// </summary>
        /// <param name="enumerator"><see cref="IEnumerator"/> that is started as a <see cref="Coroutine"/>.</param>
        /// <param name="target"> the target <see cref="MonoBehaviour"/> on which the coroutine will run.</param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#coroutines-ext">Documentation</a></footer>
        public static void Dispatch(this IEnumerator enumerator, MonoBehaviour target)
        {
            Dispatcher.Invoke(enumerator, target);
        }

        /// <summary>
        /// Dispatch an <see cref="IEnumerator"/> that will be started and executed as a <see cref="Coroutine"/> on the main thread.
        /// </summary>
        /// <param name="enumerator"><see cref="IEnumerator"/> that is started as a <see cref="Coroutine"/>.</param>
        /// <param name="cycle"> the execution cycle during which the passed <see cref="Coroutine"/> is started.</param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#coroutines-ext">Documentation</a></footer>
        public static void Dispatch(this IEnumerator enumerator, ExecutionCycle cycle)
        {
            Dispatcher.Invoke(enumerator, cycle);
        }

        /// <summary>
        /// Dispatch an <see cref="IEnumerator"/> that will be started and executed as a <see cref="Coroutine"/> on the main thread.
        /// </summary>
        /// <param name="enumerator"><see cref="IEnumerator"/> that is started as a <see cref="Coroutine"/>.</param>
        /// <param name="cycle"> the execution cycle during which the passed <see cref="Coroutine"/> is started.</param>
        /// <param name="target"> the target <see cref="MonoBehaviour"/> on which the coroutine will run.</param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#coroutines-ext">Documentation</a></footer>
        public static void Dispatch(this IEnumerator enumerator, ExecutionCycle cycle, MonoBehaviour target)
        {
            Dispatcher.Invoke(enumerator, cycle, target);
        }
        
        /// <summary>
        /// Dispatch an <see cref="IEnumerator"/> that will be started and executed as a <see cref="Coroutine"/>
        /// on the main thread; and return a <see cref="Task{Coroutine}"/>, that when awaited on the calling thread, returns
        /// the <see cref="Coroutine"/> after it was started on the main thread.
        /// </summary>
        /// <param name="enumerator"><see cref="IEnumerator"/> that is started as a <see cref="Coroutine"/>.</param>
        /// <exception cref="InvalidOperationException"> exception is thrown if an <see cref="IEnumerator"/> is dispatched during edit mode.</exception>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#coroutines-ext">Documentation</a></footer>
        public static Task<Coroutine> DispatchAsync(this IEnumerator enumerator)
        {
            return Dispatcher.InvokeAsync(enumerator);
        }
        
        /// <summary>
        /// Dispatch an <see cref="IEnumerator"/> that will be started and executed as a <see cref="Coroutine"/>
        /// on the main thread; and return a <see cref="Task{Coroutine}"/>, that when awaited on the calling thread, returns
        /// the <see cref="Coroutine"/> after it was started on the main thread.
        /// </summary>
        /// <param name="enumerator"><see cref="IEnumerator"/> that is started as a <see cref="Coroutine"/>.</param>
        /// <param name="target"> the target <see cref="MonoBehaviour"/> on which the coroutine will run.</param>
        /// <exception cref="InvalidOperationException"> exception is thrown if an <see cref="IEnumerator"/> is dispatched during edit mode.</exception>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#coroutines-ext">Documentation</a></footer>
        public static Task<Coroutine> DispatchAsync(this IEnumerator enumerator, MonoBehaviour target)
        {
            return Dispatcher.InvokeAsync(enumerator,target);
        }
        
        /// <summary>
        /// Dispatch an <see cref="IEnumerator"/> that will be started and executed as a <see cref="Coroutine"/>
        /// on the main thread; and return a <see cref="Task{Coroutine}"/>, that when awaited on the calling thread, returns
        /// the <see cref="Coroutine"/> after it was started on the main thread.
        /// </summary>
        /// <param name="enumerator"><see cref="IEnumerator"/> that is started as a <see cref="Coroutine"/>.</param>
        /// <param name="ct"> optional cancellation token that can be passed to abort the task prematurely.</param>
        /// <exception cref="InvalidOperationException"> exception is thrown if an <see cref="IEnumerator"/> is dispatched during edit mode.</exception>
        /// <exception cref="OperationCanceledException"> exception is thrown if the task is cancelled prematurely.</exception>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#coroutines-ext">Documentation</a></footer>
        public static Task<Coroutine> DispatchAsync(this IEnumerator enumerator, CancellationToken ct)
        {
            return Dispatcher.InvokeAsync(enumerator, ct);
        }

        /// <summary>
        /// Dispatch an <see cref="IEnumerator"/> that will be started and executed as a <see cref="Coroutine"/>
        /// on the main thread; and return a <see cref="Task{Coroutine}"/>, that when awaited on the calling thread, returns
        /// the <see cref="Coroutine"/> after it was started on the main thread.
        /// </summary>
        /// <param name="enumerator"><see cref="IEnumerator"/> that is started as a <see cref="Coroutine"/>.</param>
        /// <param name="target"> the target <see cref="MonoBehaviour"/> on which the coroutine will run.</param>
        /// <param name="ct"> optional cancellation token that can be passed to abort the task prematurely.</param>
        /// <exception cref="InvalidOperationException"> exception is thrown if an <see cref="IEnumerator"/> is dispatched during edit mode.</exception>
        /// <exception cref="OperationCanceledException"> exception is thrown if the task is cancelled prematurely.</exception>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#coroutines-ext">Documentation</a></footer>
        public static Task<Coroutine> DispatchAsync(this IEnumerator enumerator, MonoBehaviour target, CancellationToken ct)
        {
            return Dispatcher.InvokeAsync(enumerator,target, ct);
        }
        
        /// <summary>
        /// Dispatch an <see cref="IEnumerator"/> that will be started and executed as a <see cref="Coroutine"/>
        /// on the main thread; and return a <see cref="Task{Coroutine}"/>, that when awaited on the calling thread, returns
        /// the <see cref="Coroutine"/> after it was started on the main thread.
        /// </summary>
        /// <param name="enumerator"><see cref="IEnumerator"/> that is started as a <see cref="Coroutine"/>.</param>
        /// <param name="cycle"> the execution cycle during which the passed <see cref="Coroutine"/> is started.</param>
        /// <exception cref="InvalidOperationException"> exception is thrown if an <see cref="IEnumerator"/> is dispatched during edit mode.</exception>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#coroutines-ext">Documentation</a></footer>
        public static Task<Coroutine> DispatchAsync(this IEnumerator enumerator, ExecutionCycle cycle)
        {
            return Dispatcher.InvokeAsync(enumerator, cycle);
        }
        
        /// <summary>
        /// Dispatch an <see cref="IEnumerator"/> that will be started and executed as a <see cref="Coroutine"/>
        /// on the main thread; and return a <see cref="Task{Coroutine}"/>, that when awaited on the calling thread, returns
        /// the <see cref="Coroutine"/> after it was started on the main thread.
        /// </summary>
        /// <param name="enumerator"><see cref="IEnumerator"/> that is started as a <see cref="Coroutine"/>.</param>
        /// <param name="cycle"> the execution cycle during which the passed <see cref="Coroutine"/> is started.</param>
        /// <param name="target"> the target <see cref="MonoBehaviour"/> on which the coroutine will run.</param>
        /// <exception cref="InvalidOperationException"> exception is thrown if an <see cref="IEnumerator"/> is dispatched during edit mode.</exception>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#coroutines-ext">Documentation</a></footer>
        public static Task<Coroutine> DispatchAsync(this IEnumerator enumerator, ExecutionCycle cycle, MonoBehaviour target)
        {
            return Dispatcher.InvokeAsync(enumerator, cycle, target);
        }
        
        /// <summary>
        /// Dispatch an <see cref="IEnumerator"/> that will be started and executed as a <see cref="Coroutine"/>
        /// on the main thread; and return a <see cref="Task{Coroutine}"/>, that when awaited on the calling thread, returns
        /// the <see cref="Coroutine"/> after it was started on the main thread.
        /// </summary>
        /// <param name="enumerator"><see cref="IEnumerator"/> that is started as a <see cref="Coroutine"/>.</param>
        /// <param name="cycle"> the execution cycle during which the passed <see cref="Coroutine"/> is started.</param>
        /// <param name="ct"> optional cancellation token that can be passed to abort the task prematurely.</param>
        /// <exception cref="InvalidOperationException"> exception is thrown if an <see cref="IEnumerator"/> is dispatched during edit mode.</exception>
        /// <exception cref="OperationCanceledException"> exception is thrown if the task is cancelled prematurely.</exception>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#coroutines-ext">Documentation</a></footer>
        public static Task<Coroutine> DispatchAsync(this IEnumerator enumerator, ExecutionCycle cycle, CancellationToken ct)
        {
            return Dispatcher.InvokeAsync(enumerator, cycle, ct);
        }

        /// <summary>
        /// Dispatch an <see cref="IEnumerator"/> that will be started and executed as a <see cref="Coroutine"/>
        /// on the main thread; and return a <see cref="Task{Coroutine}"/>, that when awaited on the calling thread, returns
        /// the <see cref="Coroutine"/> after it was started on the main thread.
        /// </summary>
        /// <param name="enumerator"><see cref="IEnumerator"/> that is started as a <see cref="Coroutine"/>.</param>
        /// <param name="cycle"> the execution cycle during which the passed <see cref="Coroutine"/> is started.</param>
        /// <param name="target"> the target <see cref="MonoBehaviour"/> on which the coroutine will run.</param>
        /// <param name="ct"> optional cancellation token that can be passed to abort the task prematurely.</param>
        /// <exception cref="InvalidOperationException"> exception is thrown if an <see cref="IEnumerator"/> is dispatched during edit mode.</exception>
        /// <exception cref="OperationCanceledException"> exception is thrown if the task is cancelled prematurely.</exception>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#coroutines-ext">Documentation</a></footer>
        public static Task<Coroutine> DispatchAsync(this IEnumerator enumerator, ExecutionCycle cycle, MonoBehaviour target, CancellationToken ct)
        {
            return Dispatcher.InvokeAsync(enumerator, cycle, target, ct);
        }

        #endregion
        
        //--------------------------------------------------------------------------------------------------------------

        #region --- [TASK] ---
        
        /// <summary>
        /// Dispatch the execution of a <see cref="Task"/> to the main thread; and return a <see cref="Task"/>,
        /// that can be awaited.
        /// Tasks are by default executed during the next available<br/>
        /// Update, FixedUpdate, LateUpdate or TickUpdate cycle.<br/>
        /// Use <see cref="DispatchAsync(System.Threading.Tasks.Task, ExecutionCycle)"/>
        /// for more control over the cycle in which the dispatched <see cref="Task"/> is executed.
        /// </summary>
        /// <param name="task"><see cref="Task"/> dispatched task.</param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#task-ext">Documentation</a></footer>
        public static Task DispatchAsync(this Task task)
        {
            return Dispatcher.InvokeAsync(task);
        }
        
        /// <summary>
        /// Dispatch the execution of a <see cref="Task"/> to the main thread; and return a <see cref="Task"/>,
        /// that can be awaited.
        /// Tasks are by default executed during the next available<br/>
        /// Update, FixedUpdate, LateUpdate or TickUpdate cycle.<br/>
        /// </summary>
        /// <param name="task"><see cref="Task"/> dispatched task.</param>
        /// <param name="cycle">The execution cycle during which the passed <see cref="Task"/> is executed.</param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#task-ext">Documentation</a></footer>
        public static Task DispatchAsync(this Task task, ExecutionCycle cycle)
        {
            return Dispatcher.InvokeAsync(task, cycle);
        }
        
        /// <summary>
        /// Dispatch the execution of a <see cref="Task"/> to the main thread; and return a <see cref="Task"/>,
        /// that can be awaited.
        /// Tasks are by default executed during the next available<br/>
        /// Update, FixedUpdate, LateUpdate or TickUpdate cycle.<br/>
        /// Use <see cref="DispatchAsync(System.Threading.Tasks.Task, ExecutionCycle)"/>
        /// for more control over the cycle in which the dispatched <see cref="Task"/> is executed.
        /// </summary>
        /// <param name="task"><see cref="Task"/> dispatched task.</param>
        /// <param name="ct"> optional cancellation token that can be passed to abort the task prematurely.</param>
        /// <param name="throwOnCancellation"> </param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#task-ext">Documentation</a></footer>
        public static Task DispatchAsync(this Task task, CancellationToken ct, bool throwOnCancellation = true)
        {
            return Dispatcher.InvokeAsync(task, ct, throwOnCancellation);
        }
        
        /// <summary>
        /// Dispatch the execution of a <see cref="Task"/> to the main thread; and return a <see cref="Task"/>,
        /// that can be awaited.
        /// Tasks are by default executed during the next available<br/>
        /// Update, FixedUpdate, LateUpdate or TickUpdate cycle.<br/>
        /// </summary>
        /// <param name="task"><see cref="Task"/> dispatched task.</param>
        /// <param name="cycle">The execution cycle during which the passed <see cref="Task"/> is executed.</param>
        /// <param name="ct"> optional cancellation token that can be passed to abort the task prematurely.</param>
        /// <param name="throwOnCancellation"> </param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#task-ext">Documentation</a></footer>
        public static Task DispatchAsync(this Task task, ExecutionCycle cycle, CancellationToken ct, bool throwOnCancellation = true)
        {
            return Dispatcher.InvokeAsync(task, cycle, ct, throwOnCancellation);
        }
        
        #endregion
        
        //--------------------------------------------------------------------------------------------------------------

        #region --- [TASK<TRESULT>] ---

        /// <summary>
        /// Dispatch the execution of a <see cref="Task{TResult}"/> to the main thread; and return a <see cref="Task{TResult}"/>,
        /// that can be awaited on the calling thread after and will yield the result of the passed <see cref="Task{TResult}"/>.
        /// Tasks are by default executed during the next available<br/>
        /// Update, FixedUpdate, LateUpdate or TickUpdate cycle.<br/>
        /// Use <see cref="DispatchAsync(System.Threading.Tasks.Task, ExecutionCycle)"/>
        /// for more control over the cycle in which the dispatched <see cref="Task{TResult}"/> is executed.
        /// </summary>
        /// <param name="task"><see cref="Task{TResult}"/> dispatched task.</param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#task-TResult-ext">Documentation</a></footer>
        public static Task<TResult> DispatchAsync<TResult>(this Task<TResult> task)
        {
            return Dispatcher.InvokeAsync(task);
        }
        
        /// <summary>
        /// Dispatch the execution of a <see cref="Task{TResult}"/> to the main thread; and return a <see cref="Task{TResult}"/>,
        /// that can be awaited on the calling thread after and will yield the result of the passed <see cref="Task{TResult}"/>.
        /// Tasks are by default executed during the next available<br/>
        /// Update, FixedUpdate, LateUpdate or TickUpdate cycle.<br/>
        /// </summary>
        /// <param name="task"><see cref="Task{TResult}"/> dispatched task.</param>
        /// <param name="cycle">The execution cycle during which the passed <see cref="Task{TResult}"/> is executed.</param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#task-TResult-ext">Documentation</a></footer>
        public static Task<TResult> DispatchAsync<TResult>(this Task<TResult> task, ExecutionCycle cycle)
        {
            return Dispatcher.InvokeAsync(task, cycle);
        }
        
        /// <summary>
        /// Dispatch the execution of a <see cref="Task{TResult}"/> to the main thread; and return a <see cref="Task{TResult}"/>,
        /// that can be awaited on the calling thread after and will yield the result of the passed <see cref="Task{TResult}"/>.
        /// Tasks are by default executed during the next available<br/>
        /// Update, FixedUpdate, LateUpdate or TickUpdate cycle.<br/>
        /// Use <see cref="DispatchAsync(System.Threading.Tasks.Task, ExecutionCycle)"/>
        /// for more control over the cycle in which the dispatched <see cref="Task{TResult}"/> is executed.
        /// </summary>
        /// <param name="task"><see cref="Task{TResult}"/> dispatched task.</param>
        /// <param name="ct"> optional cancellation token that can be passed to abort the task prematurely.</param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#task-TResult-ext">Documentation</a></footer>
        public static Task<TResult> DispatchAsync<TResult>(this Task<TResult> task, CancellationToken ct)
        {
            return Dispatcher.InvokeAsync(task, ct);
        }
        
        /// <summary>
        /// Dispatch the execution of a <see cref="Task{TResult}"/> to the main thread; and return a <see cref="Task{TResult}"/>,
        /// that can be awaited on the calling thread after and will yield the result of the passed <see cref="Task{TResult}"/>.
        /// Tasks are by default executed during the next available<br/>
        /// Update, FixedUpdate, LateUpdate or TickUpdate cycle.<br/>
        /// </summary>
        /// <param name="task"><see cref="Task{TResult}"/> dispatched task.</param>
        /// <param name="cycle">The execution cycle during which the passed <see cref="Task{TResult}"/> is executed.</param>
        /// <param name="ct"> optional cancellation token that can be passed to abort the task prematurely.</param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#task-TResult-ext">Documentation</a></footer>
        public static Task<TResult> DispatchAsync<TResult>(this Task<TResult> task, ExecutionCycle cycle, CancellationToken ct)
        {
            return Dispatcher.InvokeAsync(task, cycle, ct);
        }
        
        #endregion
        
        //--------------------------------------------------------------------------------------------------------------

        #region --- [FUNC<TASK<TRESULT>>] ---

        /// <summary>
        /// Dispatch the execution of a <see cref="Func{TResult}"/> to the main thread, which yields a <see cref="Task{TResult}"/>
        /// that will then be executed on the main thread. This call returns a <see cref="Task{TResult}"/> that when awaited
        /// will yield the result of the <see cref="Task{TResult}"/> executed on the main thread.
        /// The passed delegate is by default executed during the next available<br/>
        /// Update, FixedUpdate, LateUpdate or TickUpdate cycle.<br/>
        /// </summary>
        /// <param name="func"><see cref="Func{TResult}"/> dispatched function that yields a <see cref="Task{TResult}"/> .</param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#funcTaskTResult">Documentation</a></footer>
        public static Task<TResult> DispatchAsync<TResult>(this Func<Task<TResult>> func)
        {
            return Dispatcher.InvokeAsync(func);
        }
        
        
        /// <summary>
        /// Dispatch the execution of a <see cref="Func{TResult}"/> to the main thread, which yields a <see cref="Task{TResult}"/>
        /// that will then be executed on the main thread. This call returns a <see cref="Task{TResult}"/> that when awaited
        /// will yield the result of the <see cref="Task{TResult}"/> executed on the main thread.
        /// The passed delegate is by default executed during the next available<br/>
        /// Update, FixedUpdate, LateUpdate or TickUpdate cycle.<br/>
        /// </summary>
        /// <param name="func"><see cref="Func{TResult}"/> dispatched function that yields a <see cref="Task{TResult}"/> .</param>
        /// <param name="cycle">The execution cycle during which the passed <see cref="Task{TResult}"/> is executed.</param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#funcTaskTResult">Documentation</a></footer>
        public static Task<TResult> DispatchAsync<TResult>(this Func<Task<TResult>> func, ExecutionCycle cycle)
        {
            return Dispatcher.InvokeAsync(func, cycle);
        }
        
        
        /// <summary>
        /// Dispatch the execution of a <see cref="Func{TResult}"/> to the main thread, which yields a <see cref="Task{TResult}"/>
        /// that will then be executed on the main thread. This call returns a <see cref="Task{TResult}"/> that when awaited
        /// will yield the result of the <see cref="Task{TResult}"/> executed on the main thread.
        /// The passed delegate is by default executed during the next available<br/>
        /// Update, FixedUpdate, LateUpdate or TickUpdate cycle.<br/>
        /// </summary>
        /// <param name="func"><see cref="Func{TResult}"/> dispatched function that yields a <see cref="Task{TResult}"/> .</param>
        /// <param name="ct"></param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#funcTaskTResult">Documentation</a></footer>
        public static Task<TResult> DispatchAsync<TResult>(this Func<Task<TResult>> func, CancellationToken ct)
        {
            return Dispatcher.InvokeAsync(func, ct);
        }
        
        
        /// <summary>
        /// Dispatch the execution of a <see cref="Func{TResult}"/> to the main thread, which yields a <see cref="Task{TResult}"/>
        /// that will then be executed on the main thread. This call returns a <see cref="Task{TResult}"/> that when awaited
        /// will yield the result of the <see cref="Task{TResult}"/> executed on the main thread.
        /// The passed delegate is by default executed during the next available<br/>
        /// Update, FixedUpdate, LateUpdate or TickUpdate cycle.<br/>
        /// </summary>
        /// <param name="func"><see cref="Func{TResult}"/> dispatched function that yields a <see cref="Task{TResult}"/> .</param>
        /// <param name="cycle">The execution cycle during which the passed <see cref="Task{TResult}"/> is executed.</param>
        /// <param name="ct"></param>
        /// <footer><a href="https://johnbaracuda.com/dispatcher.html#funcTaskTResult">Documentation</a></footer>
        public static Task<TResult> DispatchAsync<TResult>(this Func<Task<TResult>> func, ExecutionCycle cycle, CancellationToken ct)
        {
            return Dispatcher.InvokeAsync(func, cycle, ct);
        }
        
        #endregion

    }
}