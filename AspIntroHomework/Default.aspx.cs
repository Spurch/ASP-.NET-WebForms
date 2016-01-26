using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspIntroHomework
{
    public partial class _Default : Page
    {
        public string hello;

        protected void Pre_Init(object sender, EventArgs e)
        {
            /*
                - Check the IsPostBack property to determine whether this is the first time the page is being processed.
                - Create or re-create dynamic controls.
                - Set a master page dynamically.
                - Set the Theme property dynamically.
            */
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            /*
                - This event fires after each control has been initialized.
                - Each control's UniqueID is set and any skin settings have been applied.
                - Use this event to read or initialize control properties.
                - The "Init" event is fired first for the bottom-most control in the hierarchy, 
                  and then fired up the hierarchy until it is fired for the page itself.

            */
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            /*
                - Until now the viewstate values are not yet loaded, hence you can use this event to make 
                  changes to the view state that you want to ensure are persisted after the next postback.
                - Raised by the Page object.
                - Use this event for processing tasks that require all initialization to be complete.
            */
        }

        protected void OnPreLoad(object sender, EventArgs e)
        {
            /*
                - Raised after the page loads view state for itself and all controls, and after it processes 
                  postback data that is included with the Request instance.
                - Before the Page instance raises this event, it loads view state for itself and all controls, 
                  and then processes any postback data included with the Request instance.
                - Loads ViewState: ViewState data are loaded to controls.
                - Loads Postback data: Postback data are now handed to the page controls.
            */
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            hello = "Hello from CoDe BeHiNd! :P";

            /*
                - The Page object calls the OnLoad method on the Page object, and then recursively 
                  does the same for each child control until the page and all controls are loaded. 
                  The Load event of individual controls occurs after the Load event of the page.
                - This is the first place in the page lifecycle that all values are restored.
                - Most code checks the value of IsPostBack to avoid unnecessarily resetting state.
                - You may also call Validate and check the value of IsValid in this method.
                - You can also create dynamic controls in this method.
                - Use the OnLoad event method to set properties in controls and establish database connections.
            */
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            /*
                - Raised at the end of the event-handling stage.
                - Use this event for tasks that require that all other controls on the page be loaded.
            */
        }

        protected void OnPreRender(EventArgs e)
        {
            /*
                - Raised after the Page object has created all controls that are required in order to render the page, 
                  including child controls of composite controls.
                - The Page object raises the PreRender event on the Page object, and then recursively does the same for each child control. 
                - The PreRender event of individual controls occurs after the PreRender event of the page.
                - The PreRender event of individual controls occurs after the PreRender event of the page.
                - Allows final changes to the page or its control.
                - This event takes place before saving ViewState, so any changes made here are saved.
                - For example: After this event, you cannot change any property of a button or change any viewstate value.
                - Each data bound control whose DataSourceID property is set calls its DataBind method.
                - Use the event to make final changes to the contents of the page or its controls.
            */
        }

        protected void OnSaveStateComplete(EventArgs e)
        {
            /*
                - Raised after view state and control state have been saved for the page and for all controls.
                - Before this event occurs, ViewState has been saved for the page and for all controls.
                - Any changes to the page or controls at this point will be ignored.
                - Use this event perform tasks that require the view state to be saved, but that do not make any changes to controls.
            */
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            /*
                - This event is used for cleanup code.
                - At this point, all processing has occurred and it is safe to dispose of any remaining objects, including the Page object.
                - Cleanup can be performed on:
                    - Instances of classes, in other words objects
                    - Closing opened files
                    - Closing database connections.
                - This event occurs for each control and then for the page.
                - During the unload stage, the page and its controls have been rendered, so you cannot make further changes to the response stream.
                - If you attempt to call a method such as the Response.Write method then the page will throw an exception.
            */
        }
    }
}