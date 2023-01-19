<script lang="ts">
	import { getContext } from 'svelte';
	import { fly } from 'svelte/transition';
	import PopupContent from './PopupContent.svelte';
	import CloseButton from './CloseButton.svelte';
	import type { Entry } from '$lib/ts/entry';

	export let data: Entry;

	const { open }: any = getContext('simple-modal');

	const openPopup = () =>
		open(
			PopupContent,
			{ data: data },
			{
				closeButton: CloseButton,
				styleWindow: {
					background: 'var(--background-secondary);',
					width: '75%',
					marginTop: '-1rem',
				},
				styleContent: {
					color: 'var(--text-primary);',
				},
				transitionWindow: fly,
				transitionWindowProps: {
					y: 50,
					duration: 300,
				},
			},
		);
</script>

<button on:click={openPopup}>Rediger</button>

<style lang="scss">
	button {
		background-color: #66bb6a;
		border-radius: 5px;
		border: none;
		cursor: pointer;
		box-shadow: var(--box-shadow);
	}
</style>
