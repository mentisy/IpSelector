using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IpSelector
{
    class DrawButtons
    {
        private readonly int[] size = { 246, 58 };
        private readonly int spacing = 64;

        private readonly int[] positionStartLeft = { 53, 157 };
        private readonly int[] positionStartRight = { 511, 93 };
        private readonly int[] position = { 0, 0 };

        private readonly int thresholdForUsingDoubleColumns = 5;

        private readonly MainForm parentForm;

        private readonly List<Button> buttons = new List<Button>();

        public DrawButtons(MainForm parentForm, List<IpAddress> ipAddresses)
        {
            this.parentForm = parentForm;
            int currentButtonIndex = 1;
            position[0] = positionStartLeft[0];
            position[1] = positionStartLeft[1];

            foreach (IpAddress ipAddress in ipAddresses)
            {
                if (this.ShouldWeMoveToRightColumn(currentButtonIndex, ipAddresses.Count))
                {
                    position[0] = positionStartRight[0];
                    position[1] = positionStartRight[1];
                }
                this.CreateButton(ipAddress);
                position[1] += spacing;
                currentButtonIndex++;
            }
        }

        public void DisposeButtons()
        {
            foreach (Button button in this.buttons)
            {
                button.Dispose();
            }
        }

        private Button CreateButton(IpAddress ipAddress)
        {
            Button button = new Button
            {
                Text = string.Format("{0}\n{1}", ipAddress.name, ipAddress.ipAddress),
                Location = new System.Drawing.Point(position[0], position[1]),
                Size = new System.Drawing.Size(size[0], size[1]),
                Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Name = ipAddress.ipAddress,
            };
            button.Click += new EventHandler(this.parentForm.SetRegisteredIpButton_Click);
            this.buttons.Add(button);
            this.parentForm.Controls.Add(button);

            return button;
        }

        private bool ShouldWeMoveToRightColumn(int index, int buttonsCount)
        {
            buttonsCount--;
            int middle = (int)Math.Ceiling((double)buttonsCount / 2) + 1;
            bool indexAboveThreshold = index >= this.thresholdForUsingDoubleColumns - 1;
            bool isAtMiddle = index == middle;

            return indexAboveThreshold && isAtMiddle;
        }
    }
}
