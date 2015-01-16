/*
 * Copyright (C) 2007 The Android Open Source Project
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Dot42.DdmLib
{

	/// <summary>
	/// Implementation of <seealso cref="IShellOutputReceiver"/> that does nothing.
	/// <p/>This can be used to execute a remote shell command when the output is not needed.
	/// </summary>
	public sealed class NullOutputReceiver : IShellOutputReceiver
	{

		private static NullOutputReceiver sReceiver = new NullOutputReceiver();

		public static IShellOutputReceiver receiver
		{
			get
			{
				return sReceiver;
			}
		}

		/* (non-Javadoc)
		 * @see com.android.ddmlib.adb.IShellOutputReceiver#addOutput(byte[], int, int)
		 */
		public void addOutput(byte[] data, int offset, int length)
		{
		}

		/* (non-Javadoc)
		 * @see com.android.ddmlib.adb.IShellOutputReceiver#flush()
		 */
		public void flush()
		{
		}

		/* (non-Javadoc)
		 * @see com.android.ddmlib.adb.IShellOutputReceiver#isCancelled()
		 */
		public bool cancelled
		{
			get
			{
				return false;
			}
		}

	}

}