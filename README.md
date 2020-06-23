# SoALLoadDetector
Skies of Arcadia Legends Load Detector (Standalone testing tool)

This is adapted from https://github.com/thomasneff/CrashNSaneTrilogyLoadDetector and https://github.com/thomasneff/LiveSplit.BlackScreenDetector

# How does it work?
The method works by taking a small "screenshot" (currently 200x800) from your selected capture at the top-center of the capture region. There, it detects the maximum brightness of all pixels and detects it as a black screen if none of the pixels are brighter than the black level. This is a very conservative metric, and should only detect black screens if they are fully black. If there is need for some tolerance, the metric needs to be adapted.

# UI Options
## Start
Start simply starts the timers of the C# tool. You'll see the currently captured image region in real time, as well as the current histogram matches and required matches to detect a pause.

## Record Mode
If you want to record multiple feature vectors in succession, use record mode. If you then Start/Stop the timer, the features are put into a .csv file in the same folder as the binary.

## Record Current
This can be used to record feature snapshots during timing. It stores all the features into a .txt file in the same folder as the binary.

## Save Diagnostics
If enabled, images where the load screen is detected / not detected are saved periodically into folders "imgs_running" and "imgs_stopped". Images in "imgs_stopped" should *exclusively* contain images of "black screen", while images in "imgs_running" should *never* contain images of "black screen".
For each of these images, also the corresponding feature vectors are saved in "features_running" and "features_stopped", so please, if you report a wrong detection, attach both the relevant diagnostics image and feature_x_y.txt file. Both files have the frame count and the number of matching histogram bins in their filename to uniquely identify them.

