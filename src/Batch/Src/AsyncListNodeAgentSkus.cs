﻿namespace Microsoft.Azure.Batch
{
    using System.Diagnostics;
    using System.Linq;
    using System.Threading;
    using Models = Microsoft.Azure.Batch.Protocol.Models;

    internal class AsyncListNodeAgentSkusEnumerator : PagedEnumeratorBase<NodeAgentSku>
    {
        private readonly PoolOperations _parentPoolOps;
        private readonly BehaviorManager _behaviorMgr;
        private readonly DetailLevel _detailLevel;

        #region // constructors

        internal AsyncListNodeAgentSkusEnumerator(
                PoolOperations parentPoolOps,
                BehaviorManager behaviorMgr,
                DetailLevel detailLevel)
        {
            _parentPoolOps = parentPoolOps;
            _behaviorMgr = behaviorMgr;
            _detailLevel = detailLevel;
        }

        #endregion // constructors

        public override NodeAgentSku Current  // for IPagedEnumerator<T> and IEnumerator<T>
        {
            get
            {
                // start with the current object off of base
                object curObj = base._currentBatch[base._currentIndex];

                // it must be a protocol object from previous call
                Models.NodeAgentSku protocolObj = curObj as Models.NodeAgentSku;

                Debug.Assert(null != protocolObj);

                // wrap protocol object
                NodeAgentSku wrapped = new NodeAgentSku(protocolObj);

                return wrapped;
            }
        }

        /// <summary>
        /// fetch another batch of objects from the server
        /// </summary>
        protected async override System.Threading.Tasks.Task GetNextBatchFromServerAsync(SkipTokenHandler skipHandler, CancellationToken cancellationToken)
        {
            do
            {
                // start the protocol layer call
                var asyncTask = _parentPoolOps.ParentBatchClient.ProtocolLayer.ListNodeAgentSkus(
                    skipHandler.SkipToken,
                    _behaviorMgr,
                    _detailLevel,
                    cancellationToken);

                // wait for protocol call to complete
                var response = await asyncTask.ConfigureAwait(continueOnCapturedContext: false);

                // remember any skiptoken returned.  This also sets the bool
                skipHandler.SkipToken = response.Body.NextPageLink;

                // remember the protocol objects returned
                base._currentBatch = null;

                if (null != response.Body.GetEnumerator())
                {
                    base._currentBatch = response.Body.ToArray();
                }
            }
            // it is possible for there to be no results so we keep trying
            while (skipHandler.ThereIsMoreData && ((null == _currentBatch) || (_currentBatch.Length <= 0)));
        }
    }
}
