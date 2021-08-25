// Copyright (c) 2012-2021 Wojciech Figat. All rights reserved.

using FlaxEngine;
using FlaxEngine.GUI;

namespace FlaxEditor.GUI
{
    /// <summary>
    /// Interface for keyframes/curves editors.
    /// </summary>
    public interface IKeyframesEditor
    {
        /// <summary>
        /// Gets or sets the keyframes editor collection used by this editor.
        /// </summary>
        IKeyframesEditorContext KeyframesEditorContext { get; set; }

        /// <summary>
        /// Called when keyframes selection should be cleared for editor.
        /// </summary>
        /// <param name="editor">The source editor.</param>
        void OnKeyframesDeselect(IKeyframesEditor editor);

        /// <summary>
        /// Called when keyframes selection rectangle gets updated.
        /// </summary>
        /// <param name="editor">The source editor.</param>
        /// <param name="control">The source selection control.</param>
        /// <param name="selection">The source selection rectangle (in source control local space).</param>
        void OnKeyframesSelection(IKeyframesEditor editor, ContainerControl control, Rectangle selection);

        /// <summary>
        /// Called to calculate the total amount of selected keyframes in the editor.
        /// </summary>
        /// <returns>The selected keyframes amount.</returns>
        int OnKeyframesSelectionCount();

        /// <summary>
        /// Called when keyframes selection should be deleted for all editors.
        /// </summary>
        /// <param name="editor">The source editor.</param>
        void OnKeyframesDelete(IKeyframesEditor editor);

        /// <summary>
        /// Called when keyframes selection should be moved.
        /// </summary>
        /// <param name="editor">The source editor.</param>
        /// <param name="control">The source movement control.</param>
        /// <param name="location">The source movement location (in source control local space).</param>
        /// <param name="start">The movement start flag.</param>
        /// <param name="end">The movement end flag.</param>
        void OnKeyframesMove(IKeyframesEditor editor, ContainerControl control, Vector2 location, bool start, bool end);
    }
}
