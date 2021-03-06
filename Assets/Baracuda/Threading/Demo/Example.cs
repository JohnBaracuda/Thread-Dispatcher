using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Baracuda.Threading.Internal;
using Baracuda.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace Baracuda.Threading.Demo
{
    /// <summary>
    /// Example class, showcasing basic capabilities of the Thread Dispatcher Asset.
    /// Please read the documentation online for detailed information.<br/>
    /// <a href="https://johnbaracuda.com/dispatcher.html">View Documentation</a>
    /// </summary>
    public class Example : MonoBehaviour
    {
        [SerializeField] private Text actionText;
        [SerializeField] private Text funcText;
        [SerializeField] private Text coroutineText;
        [SerializeField] private bool throwExceptionInCoroutine = false;
        [SerializeField] private Text coroutineExceptionText;
        [SerializeField] private Text taskText;

        private void Start()
        {
            StartActionExample();
            StartFuncExample();
            StartCoroutineExample();
            StartCoroutineExampleWithException();
            StartTaskExample();
        }

        //--------------------------------------------------------------------------------------------------------------

        #region --- Example: Action ---

        private void StartActionExample()
        {
            Task.Run(ActionExampleWorker);
        }

        private async Task ActionExampleWorker()
        {
            // caching the current thread id
            var threadID = Thread.CurrentThread.ManagedThreadId;
            
            // simulating async work
            await Task.Delay(1000);
            
            
            await Dispatcher.InvokeAsync(() =>
            {
                actionText.text = $"Dispatched from Thread: {threadID:00}";
            });
        }
        
        #endregion

        //--------------------------------------------------------------------------------------------------------------

        #region --- Example: Func<TResult> ---

        private void StartFuncExample()
        {
            Task.Run(FuncExampleWorker);
        }

        private async Task FuncExampleWorker()
        {
            // caching the current thread id
            var threadID = Thread.CurrentThread.ManagedThreadId;
            
            // simulating async work
            await Task.Delay(1000);
            
            var dispatcherName = await Dispatcher.InvokeAsync(() => FindObjectOfType<Example>().gameObject.name);
            
            // simulating async work
            await Task.Delay(1000);

            await Dispatcher.InvokeAsync(() =>
            {
                funcText.text = $"Example GameObject is '{dispatcherName}' " +
                                $"Dispatched from thread: {threadID:00}";
            });
        }
        
        #endregion

        //--------------------------------------------------------------------------------------------------------------

        #region --- Example Coroutine ---

        private void StartCoroutineExample()
        {
            Task.Run(CoroutineExampleWorker);
        }

        private async Task CoroutineExampleWorker()
        {
            // caching the current thread id
            var threadID = Thread.CurrentThread.ManagedThreadId;
            
            // simulating async work
            await Task.Delay(1000);

            Dispatcher.Invoke(ExampleCoroutine(threadID));
        }

        private IEnumerator ExampleCoroutine(int threadId)
        {
            var value = 0;
            while (true)
            {
                yield return new WaitForSeconds(.5f);
                coroutineText.text = $"Working: {++value:000}% Completed | Dispatched from thread: {threadId:00}";
                
                if (value >= 100)
                {
                    break;
                }
            }
        }
        
        #endregion
        
        //--------------------------------------------------------------------------------------------------------------

        #region --- Example: Coroutine ---

        private void StartCoroutineExampleWithException()
        {
            Task.Run(CoroutineExampleWorkerWithException);
        }

        private async Task CoroutineExampleWorkerWithException()
        {
            // caching the current thread id
            var threadID = Thread.CurrentThread.ManagedThreadId;
            
            // simulating async work
            await Task.Delay(1000);

            try
            {
                await Dispatcher.InvokeAsyncAwaitCompletion(ExampleCoroutineWithException(threadID));
            }
            catch (BehaviourDisabledException behaviourDisabledException)
            {
                // This exception is thrown when the coroutines target behaviour is disabled which will also happen
                // when exiting playmode while the coroutine is still running.
                Debug.Log(behaviourDisabledException.Message);
                return;
            }
            catch (Exception exception)
            {
                Debug.LogError(exception);
                await Dispatcher.InvokeAsync(() => coroutineExceptionText.text = $"{exception.GetType().Name} Occured!");
                return;
            }

            await Dispatcher.InvokeAsync(() => coroutineExceptionText.text = "Work Completed!");
        }

        private IEnumerator ExampleCoroutineWithException(int threadId)
        {
            var value = 0;
            while (true)
            {
                yield return new WaitForSeconds(.1f);
                coroutineExceptionText.text = $"Working: {++value:000}% Completed | Dispatched from thread: {threadId:00}";

                if (throwExceptionInCoroutine && value >= 5)
                {
                    throw new InvalidOperationException("This Exception is thrown inside a Coroutine!");
                }
                
                if (value >= 100)
                {
                    break;
                }
            }
        }
        
        #endregion
        
        //--------------------------------------------------------------------------------------------------------------

        #region --- Example: Task ---

        private void StartTaskExample()
        {
            Task.Run(() => TaskExampleWorker(Dispatcher.RuntimeToken));
        }

        private async Task TaskExampleWorker(CancellationToken ct)
        {
            try
            {
                // caching the current thread id
                var threadID = Thread.CurrentThread.ManagedThreadId;
            
                // simulating async work
                await Task.Delay(2000, ct);
                Debug.Log("Start");
                var result = await Dispatcher.InvokeAsync(TaskExampleMainThread, ct)
                    .TimeoutAsync(1500, ct)
                    .IgnoreTimeoutExceptionAsync()
                    .IgnoreOperationCanceledExceptionAsync();

                await Dispatcher.InvokeAsync(() =>
                {
                    taskText.text = $"{result:00} GameObject were found at the scene root! | Dispatched from thread: {threadID:00}";
                });
            }
            catch (Exception exception)
            {
                Debug.Log(exception);
            }
        }

        private async Task<int> TaskExampleMainThread(CancellationToken ct)
        {
            var random = Random.Range(1000, 2000);
            
            await Task.Delay(random, ct);
            
            return SceneManager.GetActiveScene().GetRootGameObjects().Length;
        }
        
        #endregion
    }
}
