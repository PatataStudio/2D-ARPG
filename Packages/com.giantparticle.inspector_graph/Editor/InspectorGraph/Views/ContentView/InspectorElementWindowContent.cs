// ********************************
// (C) 2022 - Giant Particle Games
// All rights reserved.
// ********************************

using GiantParticle.InspectorGraph.Data;
using UnityEditor.UIElements;

namespace GiantParticle.InspectorGraph.ContentView
{
    internal class InspectorElementWindowContent : BaseWindowContent
    {
        private InspectorElement _view;
        private InspectorElementObserver _inspectorElementObserver;

        public InspectorElementWindowContent(IWindowData windowData)
        {
            windowData.CreateNewSerializedTarget();
            _view = new InspectorElement(windowData.SerializedObject);

            // Observer element
            _inspectorElementObserver = new InspectorElementObserver();
            _inspectorElementObserver.InspectorElementChanged += RaiseContentChanged;

            _inspectorElementObserver.ObserveInspectorElement(_view);
            this.Add(_view);
            this.AddToClassList($"{ContentViewMode.InspectorElement}");
        }

        public override void Dispose()
        {
            _inspectorElementObserver.StopObservingInspector();
            _inspectorElementObserver.InspectorElementChanged -= RaiseContentChanged;
        }
    }
}
